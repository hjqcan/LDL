namespace LDL.Client.UserControls.Sys
{
    partial class UCSite
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
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeListData = new DevExpress.XtraTreeList.TreeList();
            this.colSiteName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSiteType = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ritemlueSiteType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCurrency = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ritemlueCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSendPlace = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colProvince = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ritemlueProvince = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCity = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ritemlueCity = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colArea = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowArrivalPay = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowCollection = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAllowArrears = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueSiteType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.Caption = "允许到付";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.treeListData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(890, 568);
            this.panelControl1.TabIndex = 4;
            // 
            // treeListData
            // 
            this.treeListData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colSiteName,
            this.colSiteType,
            this.colCurrency,
            this.colSendPlace,
            this.colProvince,
            this.colCity,
            this.colArea,
            this.colAllowArrivalPay,
            this.colAllowCollection,
            this.colAllowArrears});
            this.treeListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListData.Location = new System.Drawing.Point(2, 2);
            this.treeListData.Name = "treeListData";
            this.treeListData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.treeListData.OptionsBehavior.CopyToClipboardWithNodeHierarchy = false;
            this.treeListData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemCheckEdit1,
            this.ritemlueSiteType,
            this.ritemlueProvince,
            this.ritemlueCurrency,
            this.repositoryItemLookUpEdit1,
            this.ritemlueCity});
            this.treeListData.Size = new System.Drawing.Size(886, 564);
            this.treeListData.TabIndex = 0;
            // 
            // colSiteName
            // 
            this.colSiteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteName.Caption = "站点名称";
            this.colSiteName.FieldName = "Name";
            this.colSiteName.Name = "colSiteName";
            this.colSiteName.OptionsColumn.ReadOnly = true;
            this.colSiteName.Visible = true;
            this.colSiteName.VisibleIndex = 0;
            this.colSiteName.Width = 76;
            // 
            // colSiteType
            // 
            this.colSiteType.AppearanceCell.Options.UseTextOptions = true;
            this.colSiteType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteType.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiteType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteType.Caption = "站点类型";
            this.colSiteType.ColumnEdit = this.ritemlueSiteType;
            this.colSiteType.FieldName = "Type";
            this.colSiteType.Name = "colSiteType";
            this.colSiteType.OptionsColumn.ReadOnly = true;
            this.colSiteType.Visible = true;
            this.colSiteType.VisibleIndex = 1;
            // 
            // ritemlueSiteType
            // 
            this.ritemlueSiteType.AutoHeight = false;
            this.ritemlueSiteType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ritemlueSiteType.DisplayMember = "DisplayName";
            this.ritemlueSiteType.Name = "ritemlueSiteType";
            this.ritemlueSiteType.NullText = "";
            this.ritemlueSiteType.ValueMember = "Code";
            // 
            // colCurrency
            // 
            this.colCurrency.AppearanceCell.Options.UseTextOptions = true;
            this.colCurrency.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.AppearanceHeader.Options.UseTextOptions = true;
            this.colCurrency.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCurrency.Caption = "币别";
            this.colCurrency.ColumnEdit = this.ritemlueCurrency;
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.OptionsColumn.ReadOnly = true;
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 2;
            // 
            // ritemlueCurrency
            // 
            this.ritemlueCurrency.AutoHeight = false;
            this.ritemlueCurrency.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ritemlueCurrency.DisplayMember = "DisplayName";
            this.ritemlueCurrency.Name = "ritemlueCurrency";
            this.ritemlueCurrency.ValueMember = "Code";
            // 
            // colSendPlace
            // 
            this.colSendPlace.AppearanceCell.Options.UseTextOptions = true;
            this.colSendPlace.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendPlace.AppearanceHeader.Options.UseTextOptions = true;
            this.colSendPlace.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSendPlace.Caption = "发件地";
            this.colSendPlace.FieldName = "SendPlace";
            this.colSendPlace.Name = "colSendPlace";
            this.colSendPlace.OptionsColumn.ReadOnly = true;
            this.colSendPlace.Visible = true;
            this.colSendPlace.VisibleIndex = 3;
            // 
            // colProvince
            // 
            this.colProvince.AppearanceCell.Options.UseTextOptions = true;
            this.colProvince.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProvince.AppearanceHeader.Options.UseTextOptions = true;
            this.colProvince.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProvince.Caption = "省份";
            this.colProvince.ColumnEdit = this.ritemlueProvince;
            this.colProvince.FieldName = "Province";
            this.colProvince.Name = "colProvince";
            this.colProvince.OptionsColumn.ReadOnly = true;
            this.colProvince.Visible = true;
            this.colProvince.VisibleIndex = 4;
            // 
            // ritemlueProvince
            // 
            this.ritemlueProvince.AutoHeight = false;
            this.ritemlueProvince.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ritemlueProvince.DisplayMember = "DisplayName";
            this.ritemlueProvince.Name = "ritemlueProvince";
            this.ritemlueProvince.NullText = "";
            this.ritemlueProvince.ValueMember = "Code";
            // 
            // colCity
            // 
            this.colCity.AppearanceCell.Options.UseTextOptions = true;
            this.colCity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCity.AppearanceHeader.Options.UseTextOptions = true;
            this.colCity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCity.Caption = "城市";
            this.colCity.ColumnEdit = this.ritemlueCity;
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.ReadOnly = true;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 5;
            // 
            // ritemlueCity
            // 
            this.ritemlueCity.AutoHeight = false;
            this.ritemlueCity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ritemlueCity.DisplayMember = "DisplayName";
            this.ritemlueCity.Name = "ritemlueCity";
            this.ritemlueCity.NullText = "";
            this.ritemlueCity.ValueMember = "Code";
            // 
            // colArea
            // 
            this.colArea.AppearanceCell.Options.UseTextOptions = true;
            this.colArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.AppearanceHeader.Options.UseTextOptions = true;
            this.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.Caption = "片区";
            this.colArea.FieldName = "Area";
            this.colArea.Name = "colArea";
            this.colArea.OptionsColumn.ReadOnly = true;
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 6;
            // 
            // colAllowArrivalPay
            // 
            this.colAllowArrivalPay.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowArrivalPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowArrivalPay.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowArrivalPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowArrivalPay.Caption = "允许到付";
            this.colAllowArrivalPay.FieldName = "AllowArrivalPay";
            this.colAllowArrivalPay.Name = "colAllowArrivalPay";
            this.colAllowArrivalPay.OptionsColumn.ReadOnly = true;
            this.colAllowArrivalPay.Visible = true;
            this.colAllowArrivalPay.VisibleIndex = 7;
            // 
            // colAllowCollection
            // 
            this.colAllowCollection.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowCollection.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowCollection.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowCollection.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowCollection.Caption = "代收货款";
            this.colAllowCollection.FieldName = "AllowCollection";
            this.colAllowCollection.Name = "colAllowCollection";
            this.colAllowCollection.OptionsColumn.ReadOnly = true;
            this.colAllowCollection.Visible = true;
            this.colAllowCollection.VisibleIndex = 8;
            // 
            // colAllowArrears
            // 
            this.colAllowArrears.AppearanceCell.Options.UseTextOptions = true;
            this.colAllowArrears.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowArrears.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowArrears.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowArrears.Caption = "拖欠货款";
            this.colAllowArrears.FieldName = "AllowArrears";
            this.colAllowArrears.Name = "colAllowArrears";
            this.colAllowArrears.OptionsColumn.ReadOnly = true;
            this.colAllowArrears.Visible = true;
            this.colAllowArrears.VisibleIndex = 9;
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
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // UCSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCSite";
            this.Size = new System.Drawing.Size(890, 568);
            this.Load += new System.EventHandler(this.UCSite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueSiteType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritemlueCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeListData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSiteName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSiteType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCurrency;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSendPlace;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colProvince;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCity;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colArea;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowArrivalPay;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowCollection;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAllowArrears;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ritemlueSiteType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ritemlueProvince;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ritemlueCurrency;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ritemlueCity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}
