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
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace LDL.Client.UserControls.Common
{
    public partial class FrmSite : DevExpress.XtraEditors.XtraForm
    {
        public List<CoSite> DataSource;

        public object SelectedItem;
        private bool IsMultiSelect;

        public FrmSite()
        {
            IsMultiSelect = false;
            InitializeComponent();
        }

        public FrmSite(bool isMultiSelect)
        {
            IsMultiSelect = isMultiSelect;
            InitializeComponent();
        }

        private void FrmSite_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        void InitControl()
        {
            //初始化控件显示
            treeListSite.OptionsView.ShowCheckBoxes = IsMultiSelect;
            treeListSite.OptionsSelection.MultiSelect = IsMultiSelect;
            treeListSite.Columns[0].Visible = !IsMultiSelect;
            treeListSite.Columns[1].Visible = IsMultiSelect;
            panelSelect.Visible = IsMultiSelect;
            //绑定数据
            DataSource = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            treeListSite.DataSource = DataSource;
            treeListSite.ExpandAll();
            if (SelectedItem != null)
            {
                if (!IsMultiSelect)
                {
                    treeListSite.FocusedNode = treeListSite.FindNodeByKeyID((SelectedItem as CoSite).Code);
                }
                else
                {
                    List<CoSite> lstObjects = (SelectedItem as List<CoSite>);
                    foreach (CoSite obj in lstObjects)
                    {
                        TreeListNode node = treeListSite.FindNodeByKeyID(obj.Code);
                        if (node != null)
                            node.Checked = true;
                    }
                }
            }

            if (!IsMultiSelect)
            {
                treeListSite.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(treeListSite_FocusedNodeChanged);
                treeListSite.CustomNodeCellEditForEditing += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(treeListSite_FocusedNodeChanged);
            }
        }

        bool isUserClose = false;
        void treeListSite_FocusedNodeChanged(object sender, EventArgs e)
        {
            string code = (sender as DevExpress.XtraTreeList.TreeList).FocusedNode.GetValue("Code").ToString();
            SelectedItem = DataSource.Find(obj => obj.Code == code);

            isUserClose = false;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FrmSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUserClose)
                this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            List<CoSite> selectItems = new List<CoSite>();
            foreach (TreeListNode node in treeListSite.Nodes)
                GetCheckNode(node, selectItems);
            //TreeListMultiSelection selectNodes = treeListSite.Selection;
            //foreach (TreeListNode node in selectNodes)
            //{
            //    string code = node.GetValue("Code").ToString();
            //    CoSite site = DataSource.Find(obj => obj.Code == code);
            //    selectItems.Add(site);
            //}
            SelectedItem = selectItems;

            isUserClose = false;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        void GetCheckNode(TreeListNode node, List<CoSite> lstSelectedItem)
        {
            if (node.CheckState == CheckState.Checked)
            {
                string code = node.GetValue("Code").ToString();
                CoSite site = DataSource.Find(obj => obj.Code == code);
                lstSelectedItem.Add(site);
            }

            foreach (TreeListNode childrenNode in node.Nodes)
                GetCheckNode(childrenNode, lstSelectedItem);
        }
    }
}