using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.Common;
using LDL.Client.LDLService;

namespace LDL.Client.UserControls.Sys
{
    public partial class FrmFunctionEdit : DevExpress.XtraEditors.XtraForm
    {
        DBOperateType Type;
        SysFunction Function;
        string ParentCode;

        public FrmFunctionEdit(DBOperateType type, SysFunction function, string parentCode)
        {
            InitializeComponent();
            Type = type;
            Function = function;
            ParentCode = parentCode;
        }

        private void FrmFunctionEdit_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        void BindParameter()
        {
        }

        void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtFunctionName.Text = Function.Name;
                txtCode.Text = Function.Code;
                txtControlType.Text = Function.ControlType;
                spinEditOrderID.Value = Function.OrderID;
                cheQuery.Checked = Function.QueryFlag.HasValue ? Function.QueryFlag.Value : false;
                cheInsert.Checked = Function.InsertFlag.HasValue ? Function.InsertFlag.Value : false;
                cheUpdate.Checked = Function.UpdateFlag.HasValue ? Function.UpdateFlag.Value : false;
                cheDelete.Checked = Function.DeleteFlag.HasValue ? Function.DeleteFlag.Value : false;
                cheSave.Checked = Function.SaveFlag.HasValue ? Function.SaveFlag.Value : false;
                chePrint.Checked = Function.PrintFlag.HasValue ? Function.PrintFlag.Value : false;
                cheImport.Checked = Function.ImportFlag.HasValue ? Function.ImportFlag.Value : false;
                cheExport.Checked = Function.ExportFlag.HasValue ? Function.ExportFlag.Value : false;
            }
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
                        Function = new SysFunction();
                        Function.ParentCode = ParentCode;
                        Function.Valid = true;
                    }

                    Function.Code = txtCode.Text.Trim();
                    Function.Name = txtFunctionName.Text.Trim();
                    Function.ControlType = txtControlType.Text.Trim();
                    Function.OrderID = Convert.ToInt16(spinEditOrderID.Value);
                    if (cheQuery.Checked) Function.QueryFlag = true; else Function.QueryFlag = null;
                    if (cheInsert.Checked) Function.InsertFlag = true; else Function.InsertFlag = null;
                    if (cheUpdate.Checked) Function.UpdateFlag = true; else Function.UpdateFlag = null;
                    if (cheDelete.Checked) Function.DeleteFlag = true; else Function.DeleteFlag = null;
                    if (cheSave.Checked) Function.SaveFlag = true; else Function.SaveFlag = null;
                    if (chePrint.Checked) Function.PrintFlag = true; else Function.PrintFlag = null;
                    if (cheImport.Checked) Function.ImportFlag = true; else Function.ImportFlag = null;
                    if (cheExport.Checked) Function.ExportFlag = true; else Function.ExportFlag = null;

                    Function.ModifyUser = Identity.CurrentUser.UserName;
                    Function.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertFunction(Function);
                    else
                        WcfServiceHelper.Client.UpdateFunction(Function);

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