using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.Common;
using LDL.Client.LDLService;

namespace LDL.Client.UserControls.Common
{
    public partial class FrmDepartment : DevExpress.XtraEditors.XtraForm
    {
        List<CoDepartment> DataSource;
        public object SelectedItem;

        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        void InitControl()
        {
            DataSource = FrequentlyUsedData.GetDepartmentList(false).Where(obj => obj.Valid == true).ToList();
            treeListDept.DataSource = DataSource;
            treeListDept.ExpandAll();
            if (SelectedItem != null)
                treeListDept.FocusedNode = treeListDept.FindNodeByKeyID((SelectedItem as CoDepartment).DeptCode);

            treeListDept.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(treeListSite_FocusedNodeChanged);
            treeListDept.CustomNodeCellEditForEditing += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(treeListSite_FocusedNodeChanged);
        }

        bool isUserClose = false;
        void treeListSite_FocusedNodeChanged(object sender, EventArgs e)
        {
            string code = (sender as DevExpress.XtraTreeList.TreeList).FocusedNode.GetValue("DeptCode").ToString();
            SelectedItem = DataSource.Find(obj => obj.DeptCode == code);

            isUserClose = false;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FrmDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUserClose)
                this.DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}