namespace LDL.Client.UserControls.Sys
{
    partial class UCQuoteMain
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogisticsType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDispatchType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestination = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(875, 468);
            this.panelControl1.TabIndex = 7;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(2, 2);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(871, 464);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colFeeType,
            this.colLogisticsType,
            this.colDispatchType,
            this.colSite,
            this.colDestination,
            this.colCustomer});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvData_CustomColumnDisplayText);
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colName.Caption = "报价名称";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colFeeType
            // 
            this.colFeeType.AppearanceCell.Options.UseTextOptions = true;
            this.colFeeType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFeeType.AppearanceHeader.Options.UseTextOptions = true;
            this.colFeeType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFeeType.Caption = "费用类型";
            this.colFeeType.FieldName = "FeeType";
            this.colFeeType.Name = "colFeeType";
            this.colFeeType.Visible = true;
            this.colFeeType.VisibleIndex = 1;
            // 
            // colLogisticsType
            // 
            this.colLogisticsType.AppearanceCell.Options.UseTextOptions = true;
            this.colLogisticsType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogisticsType.AppearanceHeader.Options.UseTextOptions = true;
            this.colLogisticsType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLogisticsType.Caption = "快件类型";
            this.colLogisticsType.FieldName = "LogisticsType";
            this.colLogisticsType.Name = "colLogisticsType";
            this.colLogisticsType.Visible = true;
            this.colLogisticsType.VisibleIndex = 2;
            // 
            // colDispatchType
            // 
            this.colDispatchType.AppearanceCell.Options.UseTextOptions = true;
            this.colDispatchType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDispatchType.AppearanceHeader.Options.UseTextOptions = true;
            this.colDispatchType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDispatchType.Caption = "派送方式";
            this.colDispatchType.FieldName = "DispatchType";
            this.colDispatchType.Name = "colDispatchType";
            this.colDispatchType.Visible = true;
            this.colDispatchType.VisibleIndex = 3;
            // 
            // colSite
            // 
            this.colSite.AppearanceHeader.Options.UseTextOptions = true;
            this.colSite.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSite.Caption = "寄件站点";
            this.colSite.Name = "colSite";
            this.colSite.Visible = true;
            this.colSite.VisibleIndex = 4;
            // 
            // colDestination
            // 
            this.colDestination.AppearanceHeader.Options.UseTextOptions = true;
            this.colDestination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDestination.Caption = "派件区域";
            this.colDestination.Name = "colDestination";
            this.colDestination.Visible = true;
            this.colDestination.VisibleIndex = 5;
            // 
            // colCustomer
            // 
            this.colCustomer.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomer.Caption = "报价客户";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 6;
            // 
            // colCustomers
            // 
            this.colCustomers.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomers.Caption = "gridColumn3";
            this.colCustomers.Name = "colCustomers";
            this.colCustomers.Visible = true;
            this.colCustomers.VisibleIndex = 5;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            this.toolTipController1.Rounded = true;
            // 
            // UCQuoteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCQuoteMain";
            this.Size = new System.Drawing.Size(875, 468);
            this.Load += new System.EventHandler(this.UCQuoteMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomers;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colLogisticsType;
        private DevExpress.XtraGrid.Columns.GridColumn colDispatchType;
        private DevExpress.XtraGrid.Columns.GridColumn colSite;
        private DevExpress.XtraGrid.Columns.GridColumn colDestination;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeType;
    }
}
