namespace LDL.Client.UserControls.Sys
{
    partial class UCParameter
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
            this.groupQuery = new DevExpress.XtraEditors.GroupControl();
            this.lookUpQueryType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtQueryDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeListData = new DevExpress.XtraTreeList.TreeList();
            this.colDisplayName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colQueryWord = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMark1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMark2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMark3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colOrderID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colValid = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupQuery)).BeginInit();
            this.groupQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpQueryType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupQuery
            // 
            this.groupQuery.Controls.Add(this.lookUpQueryType);
            this.groupQuery.Controls.Add(this.labelControl5);
            this.groupQuery.Controls.Add(this.txtQueryDisplayName);
            this.groupQuery.Controls.Add(this.labelControl8);
            this.groupQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupQuery.Location = new System.Drawing.Point(0, 0);
            this.groupQuery.Name = "groupQuery";
            this.groupQuery.Size = new System.Drawing.Size(997, 66);
            this.groupQuery.TabIndex = 3;
            this.groupQuery.Text = "查询";
            // 
            // lookUpQueryType
            // 
            this.lookUpQueryType.Location = new System.Drawing.Point(45, 33);
            this.lookUpQueryType.Name = "lookUpQueryType";
            this.lookUpQueryType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpQueryType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lookUpQueryType.Properties.DisplayMember = "Name";
            this.lookUpQueryType.Properties.NullText = "";
            this.lookUpQueryType.Properties.ShowHeader = false;
            this.lookUpQueryType.Properties.ValueMember = "Type";
            this.lookUpQueryType.Size = new System.Drawing.Size(150, 20);
            this.lookUpQueryType.TabIndex = 1;
            this.lookUpQueryType.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookUpQueryType_EditValueChanging);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "类型";
            // 
            // txtQueryDisplayName
            // 
            this.txtQueryDisplayName.Location = new System.Drawing.Point(246, 33);
            this.txtQueryDisplayName.Name = "txtQueryDisplayName";
            this.txtQueryDisplayName.Size = new System.Drawing.Size(150, 20);
            this.txtQueryDisplayName.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(216, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "名称";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.treeListData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(997, 556);
            this.panelControl1.TabIndex = 4;
            // 
            // treeListData
            // 
            this.treeListData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDisplayName,
            this.colCode,
            this.colFullName,
            this.colQueryWord,
            this.colMark1,
            this.colMark2,
            this.colMark3,
            this.colRemark,
            this.colOrderID,
            this.colValid});
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
            this.treeListData.Size = new System.Drawing.Size(993, 552);
            this.treeListData.TabIndex = 0;
            // 
            // colDisplayName
            // 
            this.colDisplayName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDisplayName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDisplayName.Caption = "显示名称";
            this.colDisplayName.FieldName = "DisplayName";
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.OptionsColumn.ReadOnly = true;
            this.colDisplayName.Visible = true;
            this.colDisplayName.VisibleIndex = 0;
            this.colDisplayName.Width = 76;
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
            // colFullName
            // 
            this.colFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFullName.Caption = "全称";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 2;
            this.colFullName.Width = 76;
            // 
            // colQueryWord
            // 
            this.colQueryWord.AppearanceHeader.Options.UseTextOptions = true;
            this.colQueryWord.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQueryWord.Caption = "查询简写";
            this.colQueryWord.FieldName = "QueryWord";
            this.colQueryWord.Name = "colQueryWord";
            this.colQueryWord.OptionsColumn.ReadOnly = true;
            this.colQueryWord.Visible = true;
            this.colQueryWord.VisibleIndex = 3;
            // 
            // colMark1
            // 
            this.colMark1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMark1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMark1.Caption = "标识1";
            this.colMark1.FieldName = "Mark1";
            this.colMark1.Name = "colMark1";
            this.colMark1.OptionsColumn.ReadOnly = true;
            this.colMark1.Visible = true;
            this.colMark1.VisibleIndex = 4;
            // 
            // colMark2
            // 
            this.colMark2.AppearanceHeader.Options.UseTextOptions = true;
            this.colMark2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMark2.Caption = "标识2";
            this.colMark2.FieldName = "Mark2";
            this.colMark2.Name = "colMark2";
            this.colMark2.OptionsColumn.ReadOnly = true;
            this.colMark2.Visible = true;
            this.colMark2.VisibleIndex = 5;
            // 
            // colMark3
            // 
            this.colMark3.AppearanceHeader.Options.UseTextOptions = true;
            this.colMark3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMark3.Caption = "标识3";
            this.colMark3.FieldName = "Mark3";
            this.colMark3.Name = "colMark3";
            this.colMark3.OptionsColumn.ReadOnly = true;
            this.colMark3.Visible = true;
            this.colMark3.VisibleIndex = 6;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.ReadOnly = true;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 7;
            // 
            // colOrderID
            // 
            this.colOrderID.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderID.Caption = "排序";
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.OptionsColumn.ReadOnly = true;
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 8;
            // 
            // colValid
            // 
            this.colValid.AppearanceHeader.Options.UseTextOptions = true;
            this.colValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValid.Caption = "是否有效";
            this.colValid.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.ReadOnly = true;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 9;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
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
            // UCParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupQuery);
            this.Name = "UCParameter";
            this.Size = new System.Drawing.Size(997, 622);
            ((System.ComponentModel.ISupportInitialize)(this.groupQuery)).EndInit();
            this.groupQuery.ResumeLayout(false);
            this.groupQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpQueryType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupQuery;
        private DevExpress.XtraEditors.TextEdit txtQueryDisplayName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeListData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDisplayName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colOrderID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colQueryWord;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMark1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMark2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMark3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colValid;
        private DevExpress.XtraEditors.LookUpEdit lookUpQueryType;

    }
}
