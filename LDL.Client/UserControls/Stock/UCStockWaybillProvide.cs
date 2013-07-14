using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.Common;
using LDL.Client.LDLService;

namespace LDL.Client.UserControls.Stock
{
    public partial class UCStockWaybillProvide : DevExpress.XtraEditors.XtraUserControl
    {

        #region 属性

        List<StockWaybillProvide> dataSource;
        List<CoSite> lstSite;
        Dictionary<string, object> query;

        #endregion

        public UCStockWaybillProvide()
        {
            InitializeComponent();
        }

        private void UCStockWaybillProvide_Load(object sender, EventArgs e)
        {
            BindParameter();
            ControlsHelper.InitControlSite(btneditSite);
            ControlsHelper.InitControlSite(btneditDestSite);
        }

        #region 事件

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (validationProvider.Validate())
                {
                    StockWaybillProvide provide = new StockWaybillProvide();
                    provide.SrcSite = groupHeader.Tag.ToString().Split('|')[1];
                    provide.DestSite = (btneditDestSite.Tag as CoSite).ID;
                    provide.ProvideDate = dateEditProvideDate.DateTime;
                    provide.Receiver = lookUpReceiver.EditValue == null ? "" : lookUpReceiver.EditValue.ToString();
                    provide.StartCode = txtStartCode.Text;
                    provide.EndCode = txtEndCode.Text;
                    provide.Price = spinEditPrice.Value;
                    provide.Number = Convert.ToInt16(spinEditNumber.Value);
                    provide.Remark = txtRemark.Text.Trim();
                    provide.State = "1";    //  0:审核不通过 1:审核通过  2:未审核 
                    provide.CreateUser = Identity.CurrentUser.UserName;
                    provide.CreateDate = DateTime.Now;
                    provide.Valid = true;


                    WcfServiceHelper.Client.InsertStockWaybillProvide(provide);

                    BindList();
                    popupContainer.Hide();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "保存", "保存成功");
                }
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("保存失败", ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            popupContainer.Hide();
        }

        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (query == null)
                    query = new Dictionary<string, object>();

                string codeSite = "";
                if (btneditSite.Text.Trim() != "" && btneditSite.Tag != null)
                    codeSite = (btneditSite.Tag as CoSite).Code;
                query[btneditSite.Name] = codeSite;

                BindList();
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("查询失败", ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        //新增
        void _barbtnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvWaybill.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("选择发放运单", "请从左侧表格中选择发放的运单来源");
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            ControlsHelper.ResetControls(groupHeader.Controls);
            dateEditProvideDate.DateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            _StockWaybill objWaybill = gvWaybill.GetRow(gvWaybill.FocusedRowHandle) as _StockWaybill;
            txtStartCode.Text = objWaybill.StartCode;
            txtEndCode.Text = objWaybill.EndCode;
            txtCode_Leave(null, null);
            if (objWaybill.Price.HasValue)
                spinEditPrice.Value = objWaybill.Price.Value;

            groupHeader.Tag = "NEW|" + objWaybill.OwnerSite;
            groupHeader.Text = "新增";
            popupContainer.Location = new Point((popupContainer.Parent.Width - popupContainer.Width) / 2, (popupContainer.Parent.Height - popupContainer.Height) / 2);
            popupContainer.Show();

            this.Cursor = Cursors.Default;
        }

        //删除
        void _barbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的记录");
            }
            else
            {
                StockWaybillProvide provide = (StockWaybillProvide)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除记录吗？")) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        WcfServiceHelper.Client.DeleteStockWaybillProvide(provide.ID);
                        BindList();
                        ControlsHelper.ShowAlertMessage(this.ParentForm, "删除", "删除成功");
                    }
                    catch (Exception ex)
                    {
                        ControlsHelper.ShowErrorMessage("删除失败", ex.Message);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtEndCode.Text.ToString().Length > 0 && txtStartCode.Text.ToString().Length > 0
                && txtEndCode.Text.ToString().Length == txtStartCode.Text.ToString().Length)
            {
                spinEditNumber.Value = long.Parse(txtEndCode.Text.ToString()) - long.Parse(txtStartCode.Text.ToString()) + 1;
            }
            else
            {
                spinEditNumber.Value = 0;
            }
        }

        #endregion

        #region 方法

        void BindList()
        {
            if (query == null)
                return;

            dataSource = WcfServiceHelper.Client.GetStockWaybillProvideBySite(query[btneditSite.Name].ToString()).ToList();
            gridData.DataSource = dataSource;
            gvData.BestFitColumns();

            gridWaybill.DataSource = UCStockWaybill.GetStockWaybillBySite(query[btneditSite.Name].ToString());
            gvWaybill.BestFitColumns();
        }

        void BindParameter()
        {
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["SrcSite"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
            (gvData.Columns["DestSite"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
            (gvWaybill.Columns["OwnerSite"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
            //领取人
            lookUpReceiver.Properties.DataSource = FrequentlyUsedData.GetEmployeeList(AppendType.Blank, false);
            (gvData.Columns["Receiver"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = FrequentlyUsedData.GetEmployeeList(AppendType.None, false);
        }
        #endregion

        #region 初始化工具栏，用继承类界面设计报错...

        /// <summary>
        /// 初始化工具栏，用继承类界面设计报错...
        /// </summary>
        public void InitToolbar()
        {
            ToolbarHelper.InitToolbar(this);
            ControlsHelper.AddEvent(FrmMain._barbtnQuery, _barbtnQuery_ItemClick);
            ControlsHelper.AddEvent(FrmMain._barbtnInsert, _barbtnInsert_ItemClick);
            ControlsHelper.AddEvent(FrmMain._barbtnDelete, _barbtnDelete_ItemClick);
        }

        #endregion

    }
}
