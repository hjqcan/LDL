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
    public partial class FrmEmployeeEdit : DevExpress.XtraEditors.XtraForm
    {
        DBOperateType Type;
        CoEmployee Employee;

        public FrmEmployeeEdit(DBOperateType type, CoEmployee employee)
        {
            InitializeComponent();
            Type = type;
            Employee = employee;
        }

        private void FrmEmployeeEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControls();
        }

        private void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtEmployeeCode.Text = Employee.Code;
                txtEmployeeName.Text = Employee.Name;
                lookUpEmployeeType.EditValue = Employee.Type;
                CoDepartment dept = FrequentlyUsedData.GetDepartmentList(false).Find(obj => obj.ID == Employee.DeptID && obj.Valid == true);
                if (dept == null)
                {
                    btneditDepartment.EditValue = null;
                    btneditDepartment.Tag = null;
                }
                else
                {
                    btneditDepartment.Tag = dept;
                    btneditDepartment.EditValue = dept.DeptName;
                }
                CoSite site = FrequentlyUsedData.GetSiteList(false).Find(obj => obj.ID == Employee.SiteID && obj.Valid == true);
                if (site == null)
                {
                    btneditSite.Tag = null;
                    btneditSite.EditValue = null;
                }
                else
                {
                    btneditSite.Tag = site;
                    btneditSite.EditValue = site.Name;
                }
                lookUpSuperior.EditValue = Employee.Superior;
                txtPhone.Text = Employee.Phone;
                txtBarPassword.Text = Employee.BarPassword;
                txtQueryWord.Text = Employee.QueryWord;
                txtAddress.Text = Employee.Address;
                txtRemark.Text = Employee.Remark;
            }
            ControlsHelper.InitControlSite(btneditSite);
            ControlsHelper.InitControlDepartment(btneditDepartment);
        }

        void BindParameter()
        { 
            //上级主管
            lookUpSuperior.Properties.DataSource = FrequentlyUsedData.GetEmployeeList(AppendType.Blank, false).Where(obj=>obj.Valid == true);
            
            //操作员类型
            ControlsHelper.BindLookUpByParameter(lookUpEmployeeType, "EmployeeType", AppendType.Blank, false);
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
                        Employee = new CoEmployee();
                        Employee.Code = txtEmployeeCode.Text.Trim();
                        Employee.Valid = true;
                    }

                    Employee.Name = txtEmployeeName.Text.Trim();
                    if (lookUpEmployeeType.EditValue == null)
                        Employee.Type = null;
                    else
                        Employee.Type = lookUpEmployeeType.EditValue.ToString();
                    Employee.DeptID = (btneditDepartment.Tag as CoDepartment).ID;
                    Employee.SiteID = (btneditSite.Tag as CoSite).ID;
                    if (lookUpSuperior.EditValue == null)
                        Employee.Superior = null;
                    else
                        Employee.Superior = lookUpSuperior.EditValue.ToString();
                    Employee.Phone = txtPhone.Text.Trim();
                    Employee.BarPassword = txtBarPassword.Text.Trim();
                    Employee.QueryWord = txtQueryWord.Text.Trim();
                    Employee.Address = txtAddress.Text.Trim();
                    Employee.Remark = txtRemark.Text.Trim();
                    Employee.ModifyUser = Identity.CurrentUser.UserName;
                    Employee.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertEmployee(Employee);
                    else
                        WcfServiceHelper.Client.UpdateEmployee(Employee);

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