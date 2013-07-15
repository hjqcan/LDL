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
using LDL.Client.UserControls.Common;

namespace LDL.Client.UserControls.Sys
{
    public partial class UCEmployee : DevExpress.XtraEditors.XtraUserControl
    {

        #region 属性

        List<CoEmployee> dataSource;
        List<CoDepartment> lstDepartment;
        List<CoSite> lstSite;

        #endregion

        public UCEmployee()
        {
            InitializeComponent();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            dataSource = WcfServiceHelper.Client.GetEmployeeList().ToList();
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
            FrmEmployeeEdit frm = new FrmEmployeeEdit(DBOperateType.Insert, null);
            if (frm.ShowDialog() == DialogResult.OK)
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
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的员工");
            }
            else
            {
                CoEmployee employee = (CoEmployee)gvData.GetRow(gvData.FocusedRowHandle);
                FrmEmployeeEdit frm = new FrmEmployeeEdit(DBOperateType.Update, employee);
                if (frm.ShowDialog() == DialogResult.OK)
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
                CoEmployee employee = (CoEmployee)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除员工[{0}]吗？", employee.Name)) == DialogResult.Yes)
                {
                    bool delUser = ControlsHelper.ShowConfirmMessage("确认", "是否要删除相关的登陆账号？") == DialogResult.Yes;
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        employee.ModifyUser = Identity.CurrentUser.UserName;
                        employee.ModifyDate = DateTime.Now;
                        employee.Valid = false;
                        WcfServiceHelper.Client.DeleteEmployee(employee, delUser);
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
            dataSource = WcfServiceHelper.Client.GetEmployeeList().ToList();
            gridData.DataSource = dataSource;
        }

        void BindParameter()
        {
            //部门
            lstDepartment = FrequentlyUsedData.GetDepartmentList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["DeptID"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstDepartment;
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["SiteID"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
            //上级主管
            List<CoEmployee> lstEmployee = dataSource.ToList();
            (gvData.Columns["Superior"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = dataSource;

            //操作员类型
            (gvData.Columns["Type"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = FrequentlyUsedData.GetParameterList("EmployeeType", false);
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
