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

namespace LDL.Client.UserControls.Sys
{
    public partial class UCUser : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<SysUser> dataSource;
        List<SysRole> lstRole;

        #endregion

        public UCUser()
        {
            InitializeComponent();
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
                gvData.BestFitColumns();
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
            FrmUserEdit frmUser = new FrmUserEdit(DBOperateType.Insert, null);
            if (frmUser.ShowDialog() == DialogResult.OK)
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
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的用户");
            }
            else
            {
                SysUser user = (SysUser)gvData.GetRow(gvData.FocusedRowHandle);

                FrmUserEdit frmUser = new FrmUserEdit(DBOperateType.Update, user);
                if (frmUser.ShowDialog() == DialogResult.OK)
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
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的用户");
            }
            else
            {
                SysUser user = (SysUser)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除用户[{0}]吗？", user.UserName)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        user.ModifyUser = Identity.CurrentUser.UserName;
                        user.ModifyDate = DateTime.Now;
                        user.Valid = false;
                        WcfServiceHelper.Client.UpdateUser(user);
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

        //查看或修改菜单功能
        private void gvData_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "colCommand")
            {
                this.Cursor = Cursors.WaitCursor;

                SysUser user = (SysUser)gvData.GetRow(e.RowHandle);
                SysRole role = lstRole.Find(obj => obj.RoleCode == user.RoleCode);
                FrmRoleFunction frm = new FrmRoleFunction(role, false);
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region 方法

        void BindList()
        {
            dataSource = WcfServiceHelper.Client.GetUserList().Where(obj => obj.Valid).ToList();
            gridData.DataSource = dataSource;
        }

        void BindParameter()
        {
            lstRole = WcfServiceHelper.Client.GetRoleList().ToList();
            (gvData.Columns["RoleCode"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstRole;
            List<CoEmployee> lstEmployee = FrequentlyUsedData.GetEmployeeList(AppendType.Blank, true);
            (gvData.Columns["EmployeeID"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstEmployee;
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
