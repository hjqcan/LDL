namespace LDL.Client.UserControls.Stock
{
    partial class UCStockWaybill
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
            this.btneditSite = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOwnerSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpSite = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStartCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.rilueRoleCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riLinkRoleFunction = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.riLookUpDeptCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riLookUpEmployeeType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riLookUpSuperior = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riLookUpParameter = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupQuery)).BeginInit();
            this.groupQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneditSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueRoleCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpDeptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEmployeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupQuery
            // 
            this.groupQuery.Controls.Add(this.btneditSite);
            this.groupQuery.Controls.Add(this.labelControl6);
            this.groupQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupQuery.Location = new System.Drawing.Point(0, 0);
            this.groupQuery.Name = "groupQuery";
            this.groupQuery.Size = new System.Drawing.Size(958, 66);
            this.groupQuery.TabIndex = 5;
            this.groupQuery.Text = "查询";
            // 
            // btneditSite
            // 
            this.btneditSite.Location = new System.Drawing.Point(69, 33);
            this.btneditSite.Name = "btneditSite";
            this.btneditSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneditSite.Size = new System.Drawing.Size(100, 20);
            this.btneditSite.TabIndex = 47;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "所属站点";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(958, 514);
            this.panelControl1.TabIndex = 6;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(2, 2);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.rilueRoleCode,
            this.riLinkRoleFunction,
            this.riLookUpDeptCode,
            this.riLookUpSite,
            this.riLookUpEmployeeType,
            this.riLookUpSuperior,
            this.repositoryItemComboBox1,
            this.riLookUpParameter});
            this.gridData.Size = new System.Drawing.Size(954, 510);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOwnerSite,
            this.colStartCode,
            this.colEndCode,
            this.colNumber,
            this.colPrice,
            this.colTotal});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            // 
            // colOwnerSite
            // 
            this.colOwnerSite.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerSite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerSite.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerSite.Caption = "所属站点";
            this.colOwnerSite.ColumnEdit = this.riLookUpSite;
            this.colOwnerSite.FieldName = "OwnerSite";
            this.colOwnerSite.Name = "colOwnerSite";
            this.colOwnerSite.OptionsColumn.ReadOnly = true;
            this.colOwnerSite.Visible = true;
            this.colOwnerSite.VisibleIndex = 0;
            // 
            // riLookUpSite
            // 
            this.riLookUpSite.AutoHeight = false;
            this.riLookUpSite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpSite.DisplayMember = "Name";
            this.riLookUpSite.Name = "riLookUpSite";
            this.riLookUpSite.NullText = "";
            this.riLookUpSite.ValueMember = "ID";
            // 
            // colStartCode
            // 
            this.colStartCode.AppearanceCell.Options.UseTextOptions = true;
            this.colStartCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colStartCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStartCode.Caption = "起始单号";
            this.colStartCode.FieldName = "StartCode";
            this.colStartCode.Name = "colStartCode";
            this.colStartCode.Visible = true;
            this.colStartCode.VisibleIndex = 1;
            // 
            // colEndCode
            // 
            this.colEndCode.AppearanceCell.Options.UseTextOptions = true;
            this.colEndCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colEndCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEndCode.Caption = "结束单号";
            this.colEndCode.FieldName = "EndCode";
            this.colEndCode.Name = "colEndCode";
            this.colEndCode.Visible = true;
            this.colEndCode.VisibleIndex = 2;
            // 
            // colNumber
            // 
            this.colNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumber.Caption = "数量";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 3;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrice.Caption = "单价";
            this.colPrice.DisplayFormat.FormatString = "N";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.ReadOnly = true;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "总价";
            this.colTotal.FieldName = "colTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.UnboundExpression = "Number*Price";
            this.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "菜单功能";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "菜单功能";
            // 
            // rilueRoleCode
            // 
            this.rilueRoleCode.AutoHeight = false;
            this.rilueRoleCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueRoleCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "名称")});
            this.rilueRoleCode.DisplayMember = "RoleName";
            this.rilueRoleCode.Name = "rilueRoleCode";
            this.rilueRoleCode.NullText = "";
            this.rilueRoleCode.ValueMember = "RoleCode";
            // 
            // riLinkRoleFunction
            // 
            this.riLinkRoleFunction.AutoHeight = false;
            this.riLinkRoleFunction.Caption = "菜单功能";
            this.riLinkRoleFunction.Name = "riLinkRoleFunction";
            this.riLinkRoleFunction.NullText = "菜单功能";
            // 
            // riLookUpDeptCode
            // 
            this.riLookUpDeptCode.AutoHeight = false;
            this.riLookUpDeptCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpDeptCode.DisplayMember = "DeptName";
            this.riLookUpDeptCode.Name = "riLookUpDeptCode";
            this.riLookUpDeptCode.NullText = "";
            this.riLookUpDeptCode.ValueMember = "DeptCode";
            // 
            // riLookUpEmployeeType
            // 
            this.riLookUpEmployeeType.AutoHeight = false;
            this.riLookUpEmployeeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpEmployeeType.DisplayMember = "DisplayName";
            this.riLookUpEmployeeType.Name = "riLookUpEmployeeType";
            this.riLookUpEmployeeType.NullText = "";
            this.riLookUpEmployeeType.ValueMember = "Code";
            // 
            // riLookUpSuperior
            // 
            this.riLookUpSuperior.AutoHeight = false;
            this.riLookUpSuperior.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpSuperior.DisplayMember = "EmployeeName";
            this.riLookUpSuperior.Name = "riLookUpSuperior";
            this.riLookUpSuperior.NullText = "";
            this.riLookUpSuperior.ValueMember = "EmployeeCode";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // riLookUpParameter
            // 
            this.riLookUpParameter.AutoHeight = false;
            this.riLookUpParameter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpParameter.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "名称")});
            this.riLookUpParameter.DisplayMember = "DisplayName";
            this.riLookUpParameter.Name = "riLookUpParameter";
            this.riLookUpParameter.NullText = "";
            this.riLookUpParameter.ValueMember = "Code";
            // 
            // UCStockWaybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupQuery);
            this.Name = "UCStockWaybill";
            this.Size = new System.Drawing.Size(958, 580);
            this.Load += new System.EventHandler(this.UCStockWaybill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupQuery)).EndInit();
            this.groupQuery.ResumeLayout(false);
            this.groupQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneditSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueRoleCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpDeptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEmployeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpParameter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupQuery;
        private DevExpress.XtraEditors.ButtonEdit btneditSite;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerSite;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpSite;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpEmployeeType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpSuperior;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueRoleCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkRoleFunction;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpParameter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colStartCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEndCode;

    }
}
