namespace LDL.Client.UserControls.Common
{
    partial class FrmSite
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
            this.treeListSite = new DevExpress.XtraTreeList.TreeList();
            this.colSiteName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.riLinkSite = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colSiteName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelSelect = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeListSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSelect)).BeginInit();
            this.panelSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeListSite
            // 
            this.treeListSite.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colSiteName,
            this.colSiteName1});
            this.treeListSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListSite.Location = new System.Drawing.Point(0, 0);
            this.treeListSite.Name = "treeListSite";
            this.treeListSite.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riLinkSite});
            this.treeListSite.Size = new System.Drawing.Size(484, 361);
            this.treeListSite.TabIndex = 2;
            // 
            // colSiteName
            // 
            this.colSiteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteName.Caption = "站点名称";
            this.colSiteName.ColumnEdit = this.riLinkSite;
            this.colSiteName.FieldName = "Name";
            this.colSiteName.Name = "colSiteName";
            this.colSiteName.Visible = true;
            this.colSiteName.VisibleIndex = 0;
            // 
            // riLinkSite
            // 
            this.riLinkSite.AutoHeight = false;
            this.riLinkSite.Name = "riLinkSite";
            // 
            // colSiteName1
            // 
            this.colSiteName1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiteName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteName1.Caption = "站点名称";
            this.colSiteName1.FieldName = "Name";
            this.colSiteName1.Name = "colSiteName1";
            this.colSiteName1.Visible = true;
            this.colSiteName1.VisibleIndex = 1;
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.btnSelect);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelect.Location = new System.Drawing.Point(0, 322);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(484, 39);
            this.panelSelect.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Image = global::LDL.Client.Properties.Resources.State_Validation_Valid;
            this.btnSelect.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(202, 7);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 25);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "选择(&S)";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panelSelect);
            this.Controls.Add(this.treeListSite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSite";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择站点";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSite_FormClosing);
            this.Load += new System.EventHandler(this.FrmSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSelect)).EndInit();
            this.panelSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListSite;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSiteName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkSite;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSiteName1;
        private DevExpress.XtraEditors.PanelControl panelSelect;
        private DevExpress.XtraEditors.SimpleButton btnSelect;

    }
}