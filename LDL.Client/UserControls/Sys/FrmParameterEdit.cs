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
    public partial class FrmParameterEdit : DevExpress.XtraEditors.XtraForm
    {
        DBOperateType Type;
        SysParameter Parameter;
        string ParameterType;

        public FrmParameterEdit(DBOperateType type, SysParameter parameter, string parameterType)
        {
            InitializeComponent();
            Type = type;
            Parameter = parameter;
            ParameterType = parameterType;
        }

        private void FrmParameter_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControls();
        }

        private void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtDisplayName.Text = Parameter.DisplayName;
                txtCode.Text = Parameter.Code;
                txtFullName.Text = Parameter.FullName;
                txtMark1.Text = Parameter.Mark1;
                txtMark2.Text = Parameter.Mark2;
                txtMark3.Text = Parameter.Mark3;
                txtRemark.Text = Parameter.Remark;
                txtQueryWord.Text = Parameter.QueryWord;
                spinEditOrderID.Text = Parameter.OrderID.ToString();
            }
        }

        void BindParameter()
        {
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
                        Parameter = new SysParameter();
                        Parameter.Type = ParameterType;
                        Parameter.Valid = true;
                    }

                    Parameter.Code = txtCode.Text.Trim();
                    Parameter.DisplayName = txtDisplayName.Text.Trim();
                    Parameter.FullName = txtFullName.Text.Trim();
                    Parameter.Mark1 = txtMark1.Text.Trim();
                    Parameter.Mark2 = txtMark2.Text.Trim();
                    Parameter.Mark3 = txtMark3.Text.Trim();
                    Parameter.Remark = txtRemark.Text.Trim();
                    Parameter.OrderID = Convert.ToInt16(spinEditOrderID.Value);
                    Parameter.QueryWord = txtQueryWord.Text.Trim();

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertParameter(Parameter);
                    else
                        WcfServiceHelper.Client.UpdateParameter(Parameter);

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