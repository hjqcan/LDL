namespace LDL.Client.UserControls.Sys
{
    partial class UCDestination
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpEditSite = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riLinkRoleFunction = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEditSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(936, 502);
            this.panelControl1.TabIndex = 3;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(2, 2);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riLinkRoleFunction,
            this.riLookUpEditSite});
            this.gridData.Size = new System.Drawing.Size(932, 498);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colOwnerSite});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
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
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "目的地";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colOwnerSite
            // 
            this.colOwnerSite.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerSite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerSite.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerSite.Caption = "所属站点";
            this.colOwnerSite.ColumnEdit = this.riLookUpEditSite;
            this.colOwnerSite.FieldName = "SiteID";
            this.colOwnerSite.Name = "colOwnerSite";
            this.colOwnerSite.Visible = true;
            this.colOwnerSite.VisibleIndex = 2;
            // 
            // riLookUpEditSite
            // 
            this.riLookUpEditSite.AutoHeight = false;
            this.riLookUpEditSite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpEditSite.DisplayMember = "Name";
            this.riLookUpEditSite.Name = "riLookUpEditSite";
            this.riLookUpEditSite.NullText = "";
            this.riLookUpEditSite.ValueMember = "ID";
            // 
            // riLinkRoleFunction
            // 
            this.riLinkRoleFunction.AutoHeight = false;
            this.riLinkRoleFunction.Caption = "菜单功能";
            this.riLinkRoleFunction.Name = "riLinkRoleFunction";
            this.riLinkRoleFunction.NullText = "菜单功能";
            // 
            // UCDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCDestination";
            this.Size = new System.Drawing.Size(936, 502);
            this.Load += new System.EventHandler(this.UCDestination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEditSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkRoleFunction;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerSite;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpEditSite;
    }
}
