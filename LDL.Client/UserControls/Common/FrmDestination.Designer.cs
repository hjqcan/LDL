namespace LDL.Client.UserControls.Common
{
    partial class FrmDestination
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
            this.panelSelect = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilnkName = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colOwnerSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpSite = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.CheckEditItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSelect)).BeginInit();
            this.panelSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilnkName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.btnSelect);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelect.Location = new System.Drawing.Point(0, 293);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(565, 39);
            this.panelSelect.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Image = global::LDL.Client.Properties.Resources.State_Validation_Valid;
            this.btnSelect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(242, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 25);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "选择(&S)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(565, 293);
            this.panelControl1.TabIndex = 7;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(2, 2);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riLookUpSite,
            this.CheckEditItem,
            this.rilnkName});
            this.gridData.Size = new System.Drawing.Size(561, 289);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelect,
            this.colCode,
            this.colName,
            this.colNameLink,
            this.colOwnerSite});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colSelect
            // 
            this.colSelect.AppearanceCell.Options.UseTextOptions = true;
            this.colSelect.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelect.AppearanceHeader.Options.UseTextOptions = true;
            this.colSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSelect.Caption = "选择";
            this.colSelect.FieldName = "Valid";
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 0;
            this.colSelect.Width = 40;
            // 
            // colCode
            // 
            this.colCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "编号";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowMove = false;
            this.colCode.OptionsColumn.ReadOnly = true;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            this.colCode.Width = 92;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "目的地";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowMove = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colNameLink
            // 
            this.colNameLink.AppearanceHeader.Options.UseTextOptions = true;
            this.colNameLink.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNameLink.Caption = "目的地";
            this.colNameLink.ColumnEdit = this.rilnkName;
            this.colNameLink.FieldName = "Name";
            this.colNameLink.Name = "colNameLink";
            this.colNameLink.OptionsColumn.AllowMove = false;
            this.colNameLink.OptionsColumn.ReadOnly = true;
            this.colNameLink.Visible = true;
            this.colNameLink.VisibleIndex = 3;
            // 
            // rilnkName
            // 
            this.rilnkName.AutoHeight = false;
            this.rilnkName.Name = "rilnkName";
            // 
            // colOwnerSite
            // 
            this.colOwnerSite.AppearanceCell.Options.UseTextOptions = true;
            this.colOwnerSite.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerSite.AppearanceHeader.Options.UseTextOptions = true;
            this.colOwnerSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOwnerSite.Caption = "所属站点";
            this.colOwnerSite.ColumnEdit = this.riLookUpSite;
            this.colOwnerSite.FieldName = "SiteID";
            this.colOwnerSite.Name = "colOwnerSite";
            this.colOwnerSite.OptionsColumn.ReadOnly = true;
            this.colOwnerSite.Visible = true;
            this.colOwnerSite.VisibleIndex = 4;
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
            // CheckEditItem
            // 
            this.CheckEditItem.AutoHeight = false;
            this.CheckEditItem.Name = "CheckEditItem";
            // 
            // FrmDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 332);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDestination";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择目的地";
            this.Load += new System.EventHandler(this.FrmDestination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelSelect)).EndInit();
            this.panelSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilnkName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelSelect;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerSite;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpSite;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CheckEditItem;
        private DevExpress.XtraGrid.Columns.GridColumn colNameLink;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit rilnkName;
    }
}