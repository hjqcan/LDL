using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.LDLService;
using LDL.Client.Common;

namespace LDL.Client.UserControls.Sys
{
    public partial class FrmUserEdit : DevExpress.XtraEditors.XtraForm
    {
        DBOperateType Type;
        SysUser User;

        public FrmUserEdit(DBOperateType type, SysUser user)
        {
            InitializeComponent();
            Type = type;
            User = user;
        }

        private void FrmUserEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControls();
        }

        private void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtUserName.Text = User.UserName;
                txtPassword.Text = User.Password;
                lookUpRole.EditValue = User.RoleCode;
                if (!User.EmployeeID.HasValue)
                    lookUpEmployee.EditValue = null;
                else
                    lookUpEmployee.EditValue = User.EmployeeID.Value;
                txtComputerCode.Text = User.ComputerCode;
                txtRemark.Text = User.Remark;
                cheCheckComputer.Checked = User.CheckComputer;
                cheIsLock.Checked = User.IsLock;
                cheIsAdmin.Checked = User.IsAdmin;
            }
        }

        void BindParameter()
        {
            lookUpRole.Properties.DataSource = WcfServiceHelper.Client.GetRoleList().ToList();
            List<CoEmployee> lstEmployee = FrequentlyUsedData.GetEmployeeList(AppendType.Blank, true);
            lookUpEmployee.Properties.DataSource = lstEmployee;
        }

        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (validationProvider.Validate())
                {
                    if (Type == DBOperateType.Insert)
                    {
                        User = new SysUser();
                        User.Valid = true;
                    }

                    User.UserName = txtUserName.Text.Trim();
                    User.Password = txtPassword.Text;
                    User.RoleCode = lookUpRole.EditValue.ToString();
                    if (lookUpEmployee.EditValue == null)
                        User.EmployeeID = null;
                    else
                        User.EmployeeID = (int)lookUpEmployee.EditValue;
                    User.CheckComputer = cheCheckComputer.Checked;
                    User.IsLock = cheIsLock.Checked;
                    User.IsAdmin = cheIsAdmin.Checked;
                    User.ComputerCode = txtComputerCode.Text.Trim();
                    User.Remark = txtRemark.Text.Trim();
                    User.ModifyUser = Identity.CurrentUser.UserName;
                    User.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertUser(User);
                    else
                        WcfServiceHelper.Client.UpdateUser(User);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
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
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}