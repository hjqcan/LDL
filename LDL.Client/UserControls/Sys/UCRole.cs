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
    public partial class UCRole : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<SysRole> dataSource;

        #endregion

        public UCRole()
        {
            InitializeComponent();
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

                    SysRole role;
                    string code = groupHeader.Tag.ToString().Split('|')[1];
                    if (groupHeader.Tag.ToString().StartsWith("NEW"))
                    {
                        role = new SysRole();
                        role.RoleCode = txtRoleCode.Text.Trim();
                        role.ModifyUser = Identity.CurrentUser.UserName;
                        role.ModifyDate = DateTime.Now;
                    }
                    else
                    {
                        role = dataSource.Find(obj => obj.RoleCode == code);
                    }
                    role.RoleName = txtRoleName.Text.Trim();

                    if (groupHeader.Tag.ToString().StartsWith("NEW"))
                        WcfServiceHelper.Client.InsertRole(role);
                    else
                        WcfServiceHelper.Client.UpdateRole(role);
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

            txtRoleCode.Enabled = true;
            groupHeader.Tag = "NEW|";
            groupHeader.Text = "新增";
            popupContainer.Location = new Point((Width - popupContainer.Width) / 2, (Height - popupContainer.Height) / 2);
            popupContainer.Show();

            this.Cursor = Cursors.Default;
        }

        //修改
        void _barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的角色");
            }
            else
            {
                SysRole role = (SysRole)gvData.GetRow(gvData.FocusedRowHandle);
                groupHeader.Tag = "EDIT|" + role.RoleCode;
                groupHeader.Text = "修改";

                txtRoleCode.Text = role.RoleCode;
                txtRoleName.Text = role.RoleName;

                txtRoleCode.Enabled = false;
                popupContainer.Location = new Point((Width - popupContainer.Width) / 2, (Height - popupContainer.Height) / 2);
                popupContainer.Show();
            }
            this.Cursor = Cursors.Default;
        }

        //删除
        void _barbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的角色");
            }
            else
            {
                SysRole role = (SysRole)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除角色[{0}]吗？", role.RoleName)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        WcfServiceHelper.Client.DeleteRole(role.RoleCode);
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
                SysRoleFunction userFunction = (SysRoleFunction)this.Tag;
                bool canEdit = (userFunction.InsertFlag || userFunction.UpdateFlag);
                SysRole role = (SysRole)gvData.GetRow(e.RowHandle);
                FrmRoleFunction frm = new FrmRoleFunction(role, canEdit);
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region 方法

        void BindList()
        {
            dataSource = WcfServiceHelper.Client.GetRoleList().ToList();
            gridData.DataSource = dataSource;
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
