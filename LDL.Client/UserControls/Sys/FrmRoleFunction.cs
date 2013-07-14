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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors.Repository;

namespace LDL.Client.UserControls.Sys
{
    public partial class FrmRoleFunction : DevExpress.XtraEditors.XtraForm
    {
        SysRole Role;
        List<SysFunction> FunctionList;
        List<SysFunction> dataSource;
        List<SysRoleFunction> RoleFunctionList;
        public FrmRoleFunction(SysRole role, bool canEdit)
        {
            InitializeComponent();
            Role = role;
            pnlSave.Visible = canEdit;
            if (!canEdit)
            {
                treeListData.OptionsBehavior.Editable = false;
            }
            this.Text = string.Format("角色[{0}]功能权限", role.RoleName);
        }

        private void FrmRoleFunction_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        public void InitControls()
        {
            try
            {
                FunctionList = WcfServiceHelper.Client.GetFunctionList().OrderBy(obj => obj.OrderID).ToList();
                RoleFunctionList = WcfServiceHelper.Client.GetRoleFunctionList(Role.RoleCode).ToList();
                //复制一个副本
                SysFunction[] arr = new SysFunction[FunctionList.Count];
                FunctionList.CopyTo(arr, 0);
                dataSource = new List<SysFunction>(arr);

                BindList();
                treeListData.ExpandAll();
                treeListData.ForceInitialize();
                treeListData.BestFitColumns();
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("初始化控件数据失败", ex.Message);
            }
        }

        public void BindList()
        {
            treeListData.DataSource = dataSource;
            foreach (TreeListNode node in treeListData.Nodes)
            {
                RecursorRow(node);
            }
        }

        public void RecursorRow(TreeListNode node)
        {
            InitRow(node);
            foreach (TreeListNode childrenNode in node.Nodes)
                RecursorRow(childrenNode);
        }

        public void InitRow(TreeListNode node)
        {
            string code = node.GetValue("Code").ToString();
            SysFunction func = FunctionList.Find(obj => obj.Code == code);
            SysRoleFunction roleFunction = RoleFunctionList.Find(obj => obj.FunctionCode == code);

            node.Checked = roleFunction != null;
            if (func.QueryFlag.HasValue && func.QueryFlag.Value == true)
                node.SetValue("QueryFlag", roleFunction == null ? false : roleFunction.QueryFlag);
            if (func.InsertFlag.HasValue && func.InsertFlag.Value == true)
                node.SetValue("InsertFlag", roleFunction == null ? false : roleFunction.InsertFlag);
            if (func.UpdateFlag.HasValue && func.UpdateFlag.Value == true)
                node.SetValue("UpdateFlag", roleFunction == null ? false : roleFunction.UpdateFlag);
            if (func.DeleteFlag.HasValue && func.DeleteFlag.Value == true)
                node.SetValue("DeleteFlag", roleFunction == null ? false : roleFunction.DeleteFlag);
            if (func.SaveFlag.HasValue && func.SaveFlag.Value == true)
                node.SetValue("SaveFlag", roleFunction == null ? false : roleFunction.SaveFlag);
            if (func.PrintFlag.HasValue && func.PrintFlag.Value == true)
                node.SetValue("PrintFlag", roleFunction == null ? false : roleFunction.PrintFlag);
            if (func.ImportFlag.HasValue && func.ImportFlag.Value == true)
                node.SetValue("ImportFlag", roleFunction == null ? false : roleFunction.ImportFlag);
            if (func.ExportFlag.HasValue && func.ExportFlag.Value == true)
                node.SetValue("ExportFlag", roleFunction == null ? false : roleFunction.ExportFlag);

        }

        private void treeListData_CustomNodeCellEditForEditing(object sender, DevExpress.XtraTreeList.GetCustomNodeCellEditEventArgs e)
        {
            string code = e.Node.GetValue("Code").ToString();
            SysFunction func = FunctionList.Find(obj => obj.Code == code);
            if (e.Column.Name == "colQueryFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.QueryFlag.HasValue);
            }
            else if (e.Column.Name == "colInsertFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.InsertFlag.HasValue);
            }
            else if (e.Column.Name == "colUpdateFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.UpdateFlag.HasValue);
            }
            else if (e.Column.Name == "colDeleteFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.DeleteFlag.HasValue);
            }
            else if (e.Column.Name == "colSaveFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.SaveFlag.HasValue);
            }
            else if (e.Column.Name == "colPrintFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.PrintFlag.HasValue);
            }
            else if (e.Column.Name == "colImportFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.ImportFlag.HasValue);
            }
            else if (e.Column.Name == "colExportFlag")
            {
                RepositoryItemCheckEdit che = (RepositoryItemCheckEdit)e.RepositoryItem;
                che.ReadOnly = (!func.ExportFlag.HasValue);
            }
        }

        private void treeListData_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (e.Node.GetValue("QueryFlag") != null)
                e.Node.SetValue("QueryFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("InsertFlag") != null)
                e.Node.SetValue("InsertFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("UpdateFlag") != null)
                e.Node.SetValue("UpdateFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("DeleteFlag") != null)
                e.Node.SetValue("DeleteFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("SaveFlag") != null)
                e.Node.SetValue("SaveFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("PrintFlag") != null)
                e.Node.SetValue("PrintFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("ImportFlag") != null)
                e.Node.SetValue("ImportFlag", e.State == CheckState.Checked);
            if (e.Node.GetValue("ExportFlag") != null)
                e.Node.SetValue("ExportFlag", e.State == CheckState.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                List<string> lstSelectedItem = new List<string>();
                foreach (TreeListNode node in treeListData.Nodes)
                {
                    GetCheckNode(node, lstSelectedItem);
                }

                List<SysRoleFunction> lstRoleFunction = new List<SysRoleFunction>();
                foreach (string code in lstSelectedItem)
                {
                    SysFunction func = dataSource.Find(obj => obj.Code == code);
                    SysRoleFunction roleFunc = new SysRoleFunction();
                    roleFunc.RoleCode = Role.RoleCode;
                    roleFunc.FunctionCode = func.Code;
                    roleFunc.QueryFlag = !func.QueryFlag.HasValue ? false : func.QueryFlag.Value;
                    roleFunc.InsertFlag = !func.InsertFlag.HasValue ? false : func.InsertFlag.Value;
                    roleFunc.UpdateFlag = !func.UpdateFlag.HasValue ? false : func.UpdateFlag.Value;
                    roleFunc.DeleteFlag = !func.DeleteFlag.HasValue ? false : func.DeleteFlag.Value;
                    roleFunc.SaveFlag = !func.SaveFlag.HasValue ? false : func.SaveFlag.Value;
                    roleFunc.PrintFlag = !func.PrintFlag.HasValue ? false : func.PrintFlag.Value;
                    roleFunc.ImportFlag = !func.ImportFlag.HasValue ? false : func.ImportFlag.Value;
                    roleFunc.ExportFlag = !func.ExportFlag.HasValue ? false : func.ExportFlag.Value;
                    roleFunc.CreateUser = Identity.CurrentUser.UserName;
                    roleFunc.CreateDate = DateTime.Now;
                    lstRoleFunction.Add(roleFunc);
                }

                WcfServiceHelper.Client.UpdateRoleFunction(Role.RoleCode, lstRoleFunction.ToArray());
                this.Close();
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

        void GetCheckNode(TreeListNode node, List<string> lstSelectedItem)
        {
            if (node.CheckState == CheckState.Checked || node.CheckState == CheckState.Indeterminate)
            {
                lstSelectedItem.Add(node.GetValue("Code").ToString());
                foreach (TreeListNode childrenNode in node.Nodes)
                    GetCheckNode(childrenNode, lstSelectedItem);
            }
        }
    }
}