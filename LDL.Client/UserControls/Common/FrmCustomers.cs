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
    public partial class FrmCustomers : DevExpress.XtraEditors.XtraForm
    {
        BindingList<CoCustomers> DataSource;
        public object SelectedItem;
        private bool IsMultiSelect = true;

        public FrmCustomers()
        {
            InitializeComponent();
        }

        public FrmCustomers(bool isMultiSelect)
        {
            IsMultiSelect = isMultiSelect;
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
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
            DataSource = new BindingList<CoCustomers>(FrequentlyUsedData.GetCustomersList(false).Where(obj => obj.Valid == true).ToList());
            List<CoCustomers> lstObjects = (SelectedItem as List<CoCustomers>);
            foreach (CoCustomers customer in DataSource)
            {
                customer.Valid = false;
                if (lstObjects != null && lstObjects.FindIndex(obj => obj.ID == customer.ID) >= 0)
                    customer.Valid = true;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            SelectedItem = DataSource.Where(obj => obj.Valid == true).ToList();
        }

    }
}