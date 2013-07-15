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
    public partial class UCStockWaybillRegister : DevExpress.XtraEditors.XtraUserControl
    {

        #region 属性

        List<StockWaybillRegister> dataSource;
        List<CoSite> lstSite;
        Dictionary<string, object> query;

        #endregion

        public UCStockWaybillRegister()
        {
            InitializeComponent();
        }

        private void UCStockWaybillRegister_Load(object sender, EventArgs e)
        {
            BindParameter();
            ControlsHelper.InitControlSite(btneditSite);
            ControlsHelper.InitControlSite(btneditOwnerSite);
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
                    StockWaybillRegister register = new StockWaybillRegister();
                    register.OwnerSite = (btneditOwnerSite.Tag as CoSite).ID;
                    register.Supplier = lookUpSupplier.EditValue == null ? "" : lookUpSupplier.EditValue.ToString();
                    register.StockDate = dateEditStockDate.DateTime;
                    register.StartCode = txtStartCode.Text.ToString();
                    register.EndCode = txtEndCode.Text.ToString();
                    register.Number = Convert.ToInt16(spinEditNumber.Value);
                    register.Operator = lookUpOperator.EditValue == null ? "" : lookUpOperator.EditValue.ToString();
                    register.Remark = txtRemark.Text.Trim();
                    register.CreateUser = Identity.CurrentUser.UserName;
                    register.CreateDate = DateTime.Now;
                    register.Valid = true;
                    if (spinEditPrice.Value > 0)
                        register.Price = spinEditPrice.Value / spinEditNumber.Value;

                    WcfServiceHelper.Client.InsertStockWaybillRegister(register);

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
            this.Cursor = Cursors.WaitCursor;

            ControlsHelper.ResetControls(groupHeader.Controls);
            groupHeader.Tag = "NEW|";
            groupHeader.Text = "新增";
            popupContainer.Location = new Point((Width - popupContainer.Width) / 2, (Height - popupContainer.Height) / 2);
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
                StockWaybillRegister register = (StockWaybillRegister)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除记录吗？")) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        WcfServiceHelper.Client.DeleteStockWaybillRegister(register.ID);
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

            dataSource = WcfServiceHelper.Client.GetStockWaybillRegisterBySite(query[btneditSite.Name].ToString()).ToList();
            gridData.DataSource = dataSource;
            gvData.BestFitColumns();
        }

        void BindParameter()
        {
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["OwnerSite"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
            //供应商
            lookUpSupplier.Properties.DataSource = FrequentlyUsedData.GetParameterList("Supplier", false, AppendType.Blank);
            (gvData.Columns["Supplier"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = FrequentlyUsedData.GetParameterList("Supplier", false);
            //经办人
            lookUpOperator.Properties.DataSource = FrequentlyUsedData.GetEmployeeList(AppendType.Blank, false);
            (gvData.Columns["Operator"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = FrequentlyUsedData.GetEmployeeList(AppendType.None, false);
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
