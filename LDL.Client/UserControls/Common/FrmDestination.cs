using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.LDLService;
using LDL.Client.Common;
using DevExpress.XtraEditors.Repository;

namespace LDL.Client.UserControls.Common
{
    public partial class FrmDestination : DevExpress.XtraEditors.XtraForm
    {
        BindingList<CoDestination> DataSource;
        List<CoSite> lstSite;
        public object SelectedItem;
        private bool IsMultiSelect = true;

        public FrmDestination()
        {
            InitializeComponent();
        }

        public FrmDestination(bool isMultiSelect)
        {
            IsMultiSelect = isMultiSelect;
            InitializeComponent();
        }

        private void FrmDestination_Load(object sender, EventArgs e)
        {
            BindParameter();
            InitControl();
        }

        void InitControl()
        {
            //初始化控件显示
            gvData.Columns[0].Visible = IsMultiSelect;
            gvData.Columns[2].Visible = IsMultiSelect;
            gvData.Columns[3].Visible = !IsMultiSelect;
            if (!IsMultiSelect)
                (gvData.Columns[3].ColumnEdit as RepositoryItemHyperLinkEdit).Click += new EventHandler(rilnkName_Click);
            panelSelect.Visible = IsMultiSelect;
            //绑定数据
            DataSource = new BindingList<CoDestination>(FrequentlyUsedData.GetDestinationList(false).Where(obj => obj.Valid == true).ToList());
            List<CoDestination> lstObjects = (SelectedItem as List<CoDestination>);
            foreach (CoDestination destination in DataSource)
            {
                destination.Valid = false;
                if (lstObjects != null && lstObjects.FindIndex(obj => obj.ID == destination.ID) >= 0)
                    destination.Valid = true;
            }

            gridData.DataSource = DataSource;
            gvData.BestFitColumns();
        }

        void rilnkName_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            SelectedItem = gvData.GetFocusedRow();
            this.Close();
        }

        void BindParameter()
        {
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["SiteID"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            SelectedItem = DataSource.Where(obj => obj.Valid == true).ToList();
        }

    }
}