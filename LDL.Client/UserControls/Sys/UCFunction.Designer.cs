namespace LDL.Client.UserControls.Sys
{
    partial class UCFunction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeListData = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colControlType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colOrderID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colQueryFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colInsertFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUpdateFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeleteFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSaveFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPrintFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImportFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colExportFlag = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListData
            // 
            this.treeListData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colCode,
            this.colControlType,
            this.colOrderID,
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
            this.treeListData.Location = new System.Drawing.Point(2, 2);
            this.treeListData.Name = "treeListData";
            this.treeListData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.treeListData.OptionsBehavior.CopyToClipboardWithNodeHierarchy = false;
            this.treeListData.ParentFieldName = "ParentCode";
            this.treeListData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1});
            this.treeListData.Size = new System.Drawing.Size(855, 495);
            this.treeListData.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 76;
            // 
            // colCode
            // 
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "编码";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.ReadOnly = true;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 68;
            // 
            // colControlType
            // 
            this.colControlType.AppearanceHeader.Options.UseTextOptions = true;
            this.colControlType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colControlType.Caption = "路径";
            this.colControlType.FieldName = "ControlType";
            this.colControlType.Name = "colControlType";
            this.colControlType.OptionsColumn.ReadOnly = true;
            this.colControlType.Visible = true;
            this.colControlType.VisibleIndex = 2;
            this.colControlType.Width = 76;
            // 
            // colOrderID
            // 
            this.colOrderID.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderID.Caption = "排序";
            this.colOrderID.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.OptionsColumn.ReadOnly = true;
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 3;
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
            // colQueryFlag
            // 
            this.colQueryFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colQueryFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQueryFlag.Caption = "查询功能";
            this.colQueryFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colQueryFlag.FieldName = "QueryFlag";
            this.colQueryFlag.Name = "colQueryFlag";
            this.colQueryFlag.OptionsColumn.ReadOnly = true;
            this.colQueryFlag.Visible = true;
            this.colQueryFlag.VisibleIndex = 4;
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
            this.colInsertFlag.OptionsColumn.ReadOnly = true;
            this.colInsertFlag.Visible = true;
            this.colInsertFlag.VisibleIndex = 5;
            // 
            // colUpdateFlag
            // 
            this.colUpdateFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colUpdateFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdateFlag.Caption = "修改功能";
            this.colUpdateFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colUpdateFlag.FieldName = "UpdateFlag";
            this.colUpdateFlag.Name = "colUpdateFlag";
            this.colUpdateFlag.OptionsColumn.ReadOnly = true;
            this.colUpdateFlag.Visible = true;
            this.colUpdateFlag.VisibleIndex = 6;
            // 
            // colDeleteFlag
            // 
            this.colDeleteFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeleteFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeleteFlag.Caption = "删除功能";
            this.colDeleteFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colDeleteFlag.FieldName = "DeleteFlag";
            this.colDeleteFlag.Name = "colDeleteFlag";
            this.colDeleteFlag.OptionsColumn.ReadOnly = true;
            this.colDeleteFlag.Visible = true;
            this.colDeleteFlag.VisibleIndex = 7;
            // 
            // colSaveFlag
            // 
            this.colSaveFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaveFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaveFlag.Caption = "保存功能";
            this.colSaveFlag.FieldName = "SaveFlag";
            this.colSaveFlag.Name = "colSaveFlag";
            this.colSaveFlag.OptionsColumn.ReadOnly = true;
            this.colSaveFlag.Visible = true;
            this.colSaveFlag.VisibleIndex = 8;
            // 
            // colPrintFlag
            // 
            this.colPrintFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrintFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrintFlag.Caption = "打印功能";
            this.colPrintFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colPrintFlag.FieldName = "PrintFlag";
            this.colPrintFlag.Name = "colPrintFlag";
            this.colPrintFlag.OptionsColumn.ReadOnly = true;
            this.colPrintFlag.Visible = true;
            this.colPrintFlag.VisibleIndex = 9;
            // 
            // colImportFlag
            // 
            this.colImportFlag.AppearanceHeader.Options.UseTextOptions = true;
            this.colImportFlag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colImportFlag.Caption = "导入功能";
            this.colImportFlag.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colImportFlag.FieldName = "ImportFlag";
            this.colImportFlag.Name = "colImportFlag";
            this.colImportFlag.OptionsColumn.ReadOnly = true;
            this.colImportFlag.Visible = true;
            this.colImportFlag.VisibleIndex = 10;
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
            this.colExportFlag.OptionsColumn.ReadOnly = true;
            this.colExportFlag.Visible = true;
            this.colExportFlag.VisibleIndex = 11;
            this.colExportFlag.Width = 76;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.treeListData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(859, 499);
            this.panelControl1.TabIndex = 2;
            // 
            // UCFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCFunction";
            this.Size = new System.Drawing.Size(859, 499);
            this.Load += new System.EventHandler(this.UCFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colControlType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOrderID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQueryFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colInsertFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUpdateFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeleteFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPrintFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImportFlag;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colExportFlag;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSaveFlag;
    }
}
