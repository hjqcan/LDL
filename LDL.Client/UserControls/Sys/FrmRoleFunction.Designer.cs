namespace LDL.Client.UserControls.Sys
{
    partial class FrmRoleFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSave = new DevExpress.XtraEditors.PanelControl();
            this.treeListData = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQueryFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colInsertFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUpdateFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeleteFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSaveFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPrintFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImportFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colExportFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSave)).BeginInit();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(417, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSave.Location = new System.Drawing.Point(0, 435);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(895, 39);
            this.pnlSave.TabIndex = 14;
            // 
            // treeListData
            // 
            this.treeListData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colQueryFlag,
            this.colInsertFlag,
            this.colUpdateFlag,
            this.colDeleteFlag,
            this.colSaveFlag,
            this.colPrintFlag,
            this.colImportFlag,
            this.colExportFlag});
            this.treeListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListData.KeyFieldName = "Code";
            this.treeListData.Location = new System.Drawing.Point(0, 0);
            this.treeListData.Name = "treeListData";
            this.treeListData.OptionsBehavior.AllowIncrementalSearch = true;
            this.treeListData.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeListData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.treeListData.OptionsBehavior.CopyToClipboardWithNodeHierarchy = false;
            this.treeListData.OptionsView.ShowCheckBoxes = true;
            this.treeListData.ParentFieldName = "ParentCode";
            this.treeListData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1});
            this.treeListData.Size = new System.Drawing.Size(895, 435);
            this.treeListData.TabIndex = 15;
            this.treeListData.CustomNodeCellEditForEditing += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.treeListData_CustomNodeCellEditForEditing);
            this.treeListData.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeListData_BeforeCheckNode);
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 32;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 76;
            // 
            // colQueryFlag
            // 
            this.colQueryFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colQueryFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQueryFlag.Caption = "查询功能";
            this.colQueryFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colQueryFlag.FieldName = "QueryFlag";
            this.colQueryFlag.Name = "colQueryFlag";
            this.colQueryFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colQueryFlag.Visible = true;
            this.colQueryFlag.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colInsertFlag
            // 
            this.colInsertFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colInsertFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInsertFlag.Caption = "增加功能";
            this.colInsertFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colInsertFlag.FieldName = "InsertFlag";
            this.colInsertFlag.Name = "colInsertFlag";
            this.colInsertFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colInsertFlag.Visible = true;
            this.colInsertFlag.VisibleIndex = 2;
            // 
            // colUpdateFlag
            // 
            this.colUpdateFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colUpdateFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdateFlag.Caption = "修改功能";
            this.colUpdateFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colUpdateFlag.FieldName = "UpdateFlag";
            this.colUpdateFlag.Name = "colUpdateFlag";
            this.colUpdateFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colUpdateFlag.Visible = true;
            this.colUpdateFlag.VisibleIndex = 3;
            // 
            // colDeleteFlag
            // 
            this.colDeleteFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeleteFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeleteFlag.Caption = "删除功能";
            this.colDeleteFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colDeleteFlag.FieldName = "DeleteFlag";
            this.colDeleteFlag.Name = "colDeleteFlag";
            this.colDeleteFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colDeleteFlag.Visible = true;
            this.colDeleteFlag.VisibleIndex = 4;
            // 
            // colSaveFlag
            // 
            this.colSaveFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaveFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaveFlag.Caption = "保存功能";
            this.colSaveFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colSaveFlag.FieldName = "SaveFlag";
            this.colSaveFlag.Name = "colSaveFlag";
            this.colSaveFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colSaveFlag.Visible = true;
            this.colSaveFlag.VisibleIndex = 5;
            // 
            // colPrintFlag
            // 
            this.colPrintFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrintFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrintFlag.Caption = "打印功能";
            this.colPrintFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colPrintFlag.FieldName = "PrintFlag";
            this.colPrintFlag.Name = "colPrintFlag";
            this.colPrintFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colPrintFlag.Visible = true;
            this.colPrintFlag.VisibleIndex = 6;
            // 
            // colImportFlag
            // 
            this.colImportFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportFlag.Caption = "导入功能";
            this.colImportFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colImportFlag.FieldName = "ImportFlag";
            this.colImportFlag.Name = "colImportFlag";
            this.colImportFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colImportFlag.Visible = true;
            this.colImportFlag.VisibleIndex = 7;
            this.colImportFlag.Width = 76;
            // 
            // colExportFlag
            // 
            this.colExportFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colExportFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExportFlag.Caption = "导出功能";
            this.colExportFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colExportFlag.FieldName = "ExportFlag";
            this.colExportFlag.Name = "colExportFlag";
            this.colExportFlag.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.Boolean;
            this.colExportFlag.Visible = true;
            this.colExportFlag.VisibleIndex = 8;
            this.colExportFlag.Width = 76;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // FrmRoleFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 474);
            this.Controls.Add(this.treeListData);
            this.Controls.Add(this.pnlSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoleFunction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "角色菜单";
            this.Load += new System.EventHandler(this.FrmRoleFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSave)).EndInit();
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl pnlSave;
        private DevExpress.XtraTreeList.TreeList treeListData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQueryFlag;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInsertFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUpdateFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeleteFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSaveFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImportFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExportFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPrintFlag;
    }
}