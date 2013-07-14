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
    public partial class FrmDepartmentEdit : DevExpress.XtraEditors.XtraForm
    {
        DBOperateType Type;
        CoDepartment Department;
        int ParentID;

        public FrmDepartmentEdit(DBOperateType type, CoDepartment dept, int parentID)
        {
            InitializeComponent();
            Type = type;
            Department = dept;
            ParentID = parentID;
        }

        private void FrmDepartmentEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControls();
        }

        void BindParameter()
        {
        }

        void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtName.Text = Department.DeptName;
                txtCode.Text = Department.DeptCode;
                txtRemark.Text = Department.Remark;
                spinEditOrderID.Value = Department.OrderID;
            }
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
                    if (Type == DBOperateType.Insert)
                    {
                        Department = new CoDepartment();
                        Department.DeptCode = txtCode.Text.Trim();
                        Department.ParentID = ParentID;
                        Department.Valid = true;
                    }

                    Department.DeptName = txtName.Text.Trim();
                    Department.Remark = txtRemark.Text.Trim();
                    Department.OrderID = Convert.ToInt16(spinEditOrderID.Value);
                    Department.ModifyUser = Identity.CurrentUser.UserName;
                    Department.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertDepartment(Department);
                    else
                        WcfServiceHelper.Client.UpdateDepartment(Department);

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

        #endregion
    }
}