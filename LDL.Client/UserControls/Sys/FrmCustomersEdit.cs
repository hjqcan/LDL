using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.Common;
using LDL.Client.LDLService;

namespace LDL.Client.UserControls.Sys
{
    public partial class FrmCustomersEdit : DevExpress.XtraEditors.XtraForm
    {
        #region 属性
        List<CoEmployee> lstEmployee;
        #endregion

        DBOperateType Type;
        CoCustomers Customers;

        public FrmCustomersEdit(DBOperateType type, CoCustomers customers)
        {
            InitializeComponent();
            Type = type;
            Customers = customers;
        }

        private void FrmCustomersEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            ControlsHelper.InitControlSite(btneditSite);
            InitControls();
        }

        private void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtCode.Text = Customers.Code;
                txtName.Text = Customers.Name;
                txtFullName.Text = Customers.FullName;
                CoSite site = FrequentlyUsedData.GetSiteList(false).Find(obj => obj.ID == Customers.SiteID && obj.Valid == true);
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
                txtLinkMan1.Text = Customers.LinkMan1;
                txtTel1.Text = Customers.Tel1;
                txtPhone1.Text = Customers.Phone1;
                txtLinkMan2.Text = Customers.LinkMan2;
                txtTel2.Text = Customers.Tel2;
                txtPhone2.Text = Customers.Phone2;
                txtQQ.Text = Customers.QQ;
                txtMSN.Text = Customers.MSN;
                txtFax.Text = Customers.Fax;
                txtMail.Text = Customers.Mail;
                lookUpSettlementType.EditValue = Customers.SettlementType;
                lookUpCustomersType.EditValue = Customers.CustomersType;
                txtSendPlace.Text = Customers.SendPlace;
                txtAddress.Text = Customers.Address;
                lookUpServiceEmployeeCode.EditValue = Customers.ServiceEmployeeID;
                txtPayeeName.Text = Customers.PayeeName;
                txtPayeePhone.Text = Customers.PayeePhone;
                txtBankName.Text = Customers.BankName;
                txtBankAccount.Text = Customers.BankAccount;
                cheIsTransfer.Checked = Customers.IsTransfer;
                txtTransferNO.Text = Customers.TransferNO;
                txtQueryWord.Text = Customers.QueryWork;
                txtRemark.Text = Customers.Remark;
                cheIsSMS.Checked = Customers.IsSMS;
                cheIsPrepaid.Checked = Customers.IsPrepaid;
                cheIsSpecial.Checked = Customers.IsSpecial;
            }
        }

        void BindParameter()
        {
            //所属客服
            List<CoEmployee> lstEmployee = FrequentlyUsedData.GetEmployeeByDepartment(AppendType.Blank, 1, false);
            lookUpServiceEmployeeCode.Properties.DataSource = lstEmployee;
            //结算类型
            List<SysParameter> lstSettlementType = FrequentlyUsedData.GetParameterList("SettlementType", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            lookUpSettlementType.Properties.DataSource = lstSettlementType;
            //客户类型
            List<SysParameter> lstCustomersType = FrequentlyUsedData.GetParameterList("CustomersType", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            lookUpCustomersType.Properties.DataSource = lstCustomersType;
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
                        Customers = new CoCustomers();
                        Customers.Valid = true;
                    }

                    Customers.Code = txtCode.Text.Trim();
                    Customers.Name = txtName.Text.Trim();
                    Customers.FullName = txtFullName.Text.Trim();
                    Customers.SiteID = (btneditSite.Tag as CoSite).ID;
                    Customers.LinkMan1 = txtLinkMan1.Text.Trim();
                    Customers.Tel1 = txtTel1.Text.Trim();
                    Customers.Phone1 = txtPhone1.Text.Trim();
                    Customers.LinkMan2 = txtLinkMan2.Text.Trim();
                    Customers.Tel2 = txtTel2.Text.Trim();
                    Customers.Phone2 = txtPhone2.Text.Trim();
                    Customers.QQ = txtQQ.Text.Trim();
                    Customers.Fax = txtFax.Text.Trim();
                    Customers.MSN = txtMSN.Text.Trim();
                    Customers.Mail = txtMail.Text.Trim();
                    Customers.SettlementType = lookUpSettlementType.EditValue.ToString();
                    Customers.CustomersType = lookUpCustomersType.EditValue.ToString();
                    Customers.SendPlace = txtSendPlace.Text.Trim();
                    Customers.Address = txtAddress.Text.Trim();
                    if (lookUpServiceEmployeeCode.EditValue == null)
                        Customers.ServiceEmployeeID = null;
                    else
                        Customers.ServiceEmployeeID = (int)lookUpServiceEmployeeCode.EditValue;
                    CoEmployee employee = FrequentlyUsedData.GetEmployeeByDepartment(AppendType.None, 1, false).Find(obj => obj.ID == Customers.ServiceEmployeeID);
                    Customers.ServiceEmployeeName = employee == null ? "" : employee.Name;
                    Customers.PayeeName = txtPayeeName.Text.Trim();
                    Customers.PayeePhone = txtPayeePhone.Text.Trim();
                    Customers.BankName = txtBankName.Text.Trim();
                    Customers.BankAccount = txtBankAccount.Text.Trim();
                    Customers.IsTransfer = cheIsTransfer.Checked;
                    Customers.TransferNO = txtTransferNO.Text.Trim();
                    Customers.QueryWork = txtQueryWord.Text.Trim();
                    Customers.Remark = txtRemark.Text.Trim();
                    Customers.IsSMS = cheIsSMS.Checked;
                    Customers.IsPrepaid = cheIsPrepaid.Checked;
                    Customers.IsSpecial = cheIsSpecial.Checked;
                    Customers.ModifyUser = Identity.CurrentUser.UserName;
                    Customers.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertCustomers(Customers);
                    else
                        WcfServiceHelper.Client.UpdateCustomers(Customers);

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