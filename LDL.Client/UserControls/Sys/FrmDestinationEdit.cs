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
    public partial class FrmDestinationEdit : DevExpress.XtraEditors.XtraForm
    {
        DBOperateType Type;
        CoDestination Destination;

        public FrmDestinationEdit(DBOperateType type, CoDestination destination)
        {
            InitializeComponent();
            Type = type;
            Destination = destination;
        }

        private void FrmDestinationEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControls();
        }

        private void InitControls()
        {
            if (Type == DBOperateType.Update)
            {
                txtCode.Text = Destination.Code;
                txtName.Text = Destination.Name;
                CoSite site = FrequentlyUsedData.GetSiteList(false).Find(obj => obj.ID == Destination.SiteID);
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
            }
            ControlsHelper.InitControlSite(btneditSite);
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
                        Destination = new CoDestination();
                        Destination.Code = txtCode.Text.Trim();
                        Destination.Valid = true;
                    }

                    Destination.Name = txtName.Text.Trim();
                    Destination.SiteID = (btneditSite.Tag as CoSite).ID;
                    Destination.ModifyUser = Identity.CurrentUser.UserName;
                    Destination.ModifyDate = DateTime.Now;

                    if (Type == DBOperateType.Insert)
                        WcfServiceHelper.Client.InsertDestination(Destination);
                    else
                        WcfServiceHelper.Client.UpdateDestination(Destination);

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