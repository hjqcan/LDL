using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.LDLService;
using LDL.Client.Common;

namespace LDL.Client.UserControls.Sys
{
    public partial class UCCustomers : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<CoCustomers> dataSource;
        List<CoEmployee> lstEmployee;
        List<CoSite> lstSite;
        #endregion

        public UCCustomers()
        {
            InitializeComponent();
        }

        private void UCCustomers_Load(object sender, EventArgs e)
        {
            BindParameter();
        }

        #region 事件


        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
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
            FrmCustomersEdit frmCustomers = new FrmCustomersEdit(DBOperateType.Insert, null);
            if (frmCustomers.ShowDialog() == DialogResult.OK)
            {
                BindList();
                ControlsHelper.ShowAlertMessage(this.ParentForm, "新增", "新增成功");
            }
            this.Cursor = Cursors.Default;
        }

        //修改
        void _barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的客户");
            }
            else
            {
                CoCustomers customers = (CoCustomers)gvData.GetRow(gvData.FocusedRowHandle);
                FrmCustomersEdit frmCustomers = new FrmCustomersEdit(DBOperateType.Update, customers);
                if (frmCustomers.ShowDialog() == DialogResult.OK)
                {
                    BindList();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "修改", "修改成功");
                }
            }
            this.Cursor = Cursors.Default;
        }

        //删除
        void _barbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的员工");
            }
            else
            {
                CoCustomers customers = (CoCustomers)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除客户[{0}]吗？", customers.Name)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        customers.ModifyUser = Identity.CurrentUser.UserName;
                        customers.ModifyDate = DateTime.Now;
                        customers.Valid = false;
                        WcfServiceHelper.Client.UpdateCustomers(customers);
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

        #endregion

        #region 方法

        void BindList()
        {
            dataSource = FrequentlyUsedData.GetCustomersList(true).Where(obj => obj.Valid == true).ToList();
            gridData.DataSource = dataSource;
        }

        void BindParameter()
        {
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["SiteID"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
            //结算类型
            List<SysParameter> lstSettlementType = FrequentlyUsedData.GetParameterList("SettlementType", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["SettlementType"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSettlementType;
            //客户类型
            List<SysParameter> lstCustomersType = FrequentlyUsedData.GetParameterList("CustomersType", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["CustomersType"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstCustomersType;
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
            ControlsHelper.AddEvent(FrmMain._barbtnUpdate, _barbtnUpdate_ItemClick);
            ControlsHelper.AddEvent(FrmMain._barbtnDelete, _barbtnDelete_ItemClick);
        }

        #endregion

    }
}
