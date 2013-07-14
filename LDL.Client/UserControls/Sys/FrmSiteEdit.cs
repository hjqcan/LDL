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
    public partial class FrmSiteEdit : DevExpress.XtraEditors.XtraForm
    {
        List<SysParameter> lstCity;
        DBOperateType Type;
        CoSite Site;
        string ParentID;

        public FrmSiteEdit(DBOperateType type, CoSite site, string parentID)
        {
            InitializeComponent();
            Type = type;
            Site = site;
            ParentID = parentID;
        }

        private void FrmSiteEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControls();
        }

        void BindParameter()
        {
            List<SysParameter> lstProvince = FrequentlyUsedData.GetParameterList("Province", false);
            lookUpProvince.Properties.DataSource = lstProvince;

            List<SysParameter> lstSiteType = FrequentlyUsedData.GetParameterList("SiteType", false);
            lookUpSiteType.Properties.DataSource = lstSiteType;

            List<SysParameter> lstCurrency = FrequentlyUsedData.GetParameterList("Currency", false);
            lookUpCurrency.Properties.DataSource = lstCurrency;

            lstCity = FrequentlyUsedData.GetParameterList("City", false);
        }

        void InitControls()
        {
            string id = Type == DBOperateType.Insert ? ParentID : Site.ParentID;
            CoSite siteParent = FrequentlyUsedData.GetSiteList(false).FirstOrDefault(obj => obj.ID == id);

            if (Type == DBOperateType.Update)
            {
                txtSiteName.Text = Site.Name;
                txtCode.Text = Site.Code;
                txtSendPlace.Text = Site.SendPlace;
                lookUpProvince.EditValue = Site.Province;
                lookUpCity.EditValue = Site.City;
                txtArea.Text = Site.Area;
                lookUpSiteType.EditValue = Site.Type;
                lookUpCurrency.EditValue = Site.Currency;
                cheAllowArrivalPay.Checked = Site.AllowArrivalPay;
                cheAllowCollection.Checked = Site.AllowCollection;
                cheAllowArrears.Checked = Site.AllowArrears;
            }

            if (siteParent != null)
                txtOwnerSite.Text = siteParent.Name;
        }

        #region 事件

        //省份变更时
        private void lookUpProvince_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue == null)
                lookUpCity.Properties.DataSource = null;
            else
                lookUpCity.Properties.DataSource = lstCity.Where(obj => obj.ParentCode == e.NewValue.ToString()).OrderBy(obj => obj.OrderID).ToList();
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
                        Site = new CoSite();
                        Site.ParentID = ParentID;
                        Site.Code = txtCode.Text.Trim();
                        Site.Valid = true;
                    }

                    Site.Name = txtSiteName.Text.Trim();
                    Site.SendPlace = txtSendPlace.Text.Trim();
                    Site.Province = lookUpProvince.EditValue == null ? "" : lookUpProvince.EditValue.ToString();
                    Site.City = lookUpCity.EditValue == null ? "" : lookUpCity.EditValue.ToString();
                    Site.Area = txtArea.Text.Trim();
                    Site.Type = lookUpSiteType.EditValue.ToString();
                    Site.Currency = lookUpCurrency.EditValue.ToString();
                    Site.AllowArrivalPay = cheAllowArrivalPay.Checked;
                    Site.AllowCollection = cheAllowCollection.Checked;
                    Site.AllowArrears = cheAllowArrears.Checked;
                    Site.ModifyUser = Identity.CurrentUser.UserName;
                    Site.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertSite(Site);
                    else
                        WcfServiceHelper.Client.UpdateSite(Site);

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