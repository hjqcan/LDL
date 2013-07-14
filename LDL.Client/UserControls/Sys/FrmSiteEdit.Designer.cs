namespace LDL.Client.UserControls.Sys
{
    partial class FrmSiteEdit
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lookUpCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpSiteType = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpCity = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpProvince = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtSiteName = new DevExpress.XtraEditors.TextEdit();
            this.cheAllowArrears = new DevExpress.XtraEditors.CheckEdit();
            this.cheAllowCollection = new DevExpress.XtraEditors.CheckEdit();
            this.cheAllowArrivalPay = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSendPlace = new DevExpress.XtraEditors.TextEdit();
            this.txtArea = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOwnerSite = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSiteType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowArrears.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowCollection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowArrivalPay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendPlace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnerSite.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpCurrency
            // 
            this.lookUpCurrency.Location = new System.Drawing.Point(438, 67);
            this.lookUpCurrency.Name = "lookUpCurrency";
            this.lookUpCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "名称")});
            this.lookUpCurrency.Properties.DisplayMember = "DisplayName";
            this.lookUpCurrency.Properties.NullText = "请选择";
            this.lookUpCurrency.Properties.ValueMember = "Code";
            this.lookUpCurrency.Size = new System.Drawing.Size(120, 20);
            this.lookUpCurrency.TabIndex = 57;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "请选择币别";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.lookUpCurrency, conditionValidationRule5);
            // 
            // lookUpSiteType
            // 
            this.lookUpSiteType.Location = new System.Drawing.Point(258, 67);
            this.lookUpSiteType.Name = "lookUpSiteType";
            this.lookUpSiteType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSiteType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "名称")});
            this.lookUpSiteType.Properties.DisplayMember = "DisplayName";
            this.lookUpSiteType.Properties.NullText = "请选择";
            this.lookUpSiteType.Properties.ValueMember = "Code";
            this.lookUpSiteType.Size = new System.Drawing.Size(120, 20);
            this.lookUpSiteType.TabIndex = 56;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "请选择站点类型";
            conditionValidationRule6.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.lookUpSiteType, conditionValidationRule6);
            // 
            // lookUpCity
            // 
            this.lookUpCity.Location = new System.Drawing.Point(258, 37);
            this.lookUpCity.Name = "lookUpCity";
            this.lookUpCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "名称")});
            this.lookUpCity.Properties.DisplayMember = "DisplayName";
            this.lookUpCity.Properties.NullText = "请选择";
            this.lookUpCity.Properties.ValueMember = "Code";
            this.lookUpCity.Size = new System.Drawing.Size(120, 20);
            this.lookUpCity.TabIndex = 55;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "请选择城市";
            conditionValidationRule7.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.lookUpCity, conditionValidationRule7);
            // 
            // lookUpProvince
            // 
            this.lookUpProvince.Location = new System.Drawing.Point(66, 37);
            this.lookUpProvince.Name = "lookUpProvince";
            this.lookUpProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpProvince.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "名称")});
            this.lookUpProvince.Properties.DisplayMember = "DisplayName";
            this.lookUpProvince.Properties.NullText = "请选择";
            this.lookUpProvince.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpProvince.Properties.ValueMember = "Code";
            this.lookUpProvince.Size = new System.Drawing.Size(120, 20);
            this.lookUpProvince.TabIndex = 54;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "请选择省份";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.lookUpProvince, conditionValidationRule1);
            this.lookUpProvince.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookUpProvince_EditValueChanging);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(258, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 20);
            this.txtCode.TabIndex = 39;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "站点编码不能为空";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtCode, conditionValidationRule2);
            // 
            // txtSiteName
            // 
            this.txtSiteName.Location = new System.Drawing.Point(66, 9);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(120, 20);
            this.txtSiteName.TabIndex = 38;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "站点名称不能为空";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtSiteName, conditionValidationRule3);
            // 
            // cheAllowArrears
            // 
            this.cheAllowArrears.Location = new System.Drawing.Point(244, 101);
            this.cheAllowArrears.Name = "cheAllowArrears";
            this.cheAllowArrears.Properties.Caption = "拖欠货款";
            this.cheAllowArrears.Size = new System.Drawing.Size(69, 19);
            this.cheAllowArrears.TabIndex = 53;
            // 
            // cheAllowCollection
            // 
            this.cheAllowCollection.Location = new System.Drawing.Point(156, 101);
            this.cheAllowCollection.Name = "cheAllowCollection";
            this.cheAllowCollection.Properties.Caption = "代收货款";
            this.cheAllowCollection.Size = new System.Drawing.Size(69, 19);
            this.cheAllowCollection.TabIndex = 52;
            // 
            // cheAllowArrivalPay
            // 
            this.cheAllowArrivalPay.Location = new System.Drawing.Point(64, 101);
            this.cheAllowArrivalPay.Name = "cheAllowArrivalPay";
            this.cheAllowArrivalPay.Properties.Caption = "允许到付";
            this.cheAllowArrivalPay.Size = new System.Drawing.Size(69, 19);
            this.cheAllowArrivalPay.TabIndex = 51;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(408, 70);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 14);
            this.labelControl10.TabIndex = 50;
            this.labelControl10.Text = "币别";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(24, 70);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 14);
            this.labelControl9.TabIndex = 49;
            this.labelControl9.Text = "发件地";
            // 
            // txtSendPlace
            // 
            this.txtSendPlace.Location = new System.Drawing.Point(66, 67);
            this.txtSendPlace.Name = "txtSendPlace";
            this.txtSendPlace.Size = new System.Drawing.Size(120, 20);
            this.txtSendPlace.TabIndex = 48;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(438, 37);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(120, 20);
            this.txtArea.TabIndex = 47;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(408, 40);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 46;
            this.labelControl8.Text = "片区";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(228, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "城市";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "省份";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(204, 70);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "站点类型";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 138);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(600, 40);
            this.panelControl2.TabIndex = 42;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(223, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::LDL.Client.Properties.Resources.Action_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(309, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(204, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "站点编码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "站点名称";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(384, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "所属站点";
            // 
            // txtOwnerSite
            // 
            this.txtOwnerSite.Location = new System.Drawing.Point(438, 9);
            this.txtOwnerSite.Name = "txtOwnerSite";
            this.txtOwnerSite.Properties.ReadOnly = true;
            this.txtOwnerSite.Size = new System.Drawing.Size(120, 20);
            this.txtOwnerSite.TabIndex = 59;
            // 
            // FrmSiteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 178);
            this.Controls.Add(this.txtOwnerSite);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookUpCurrency);
            this.Controls.Add(this.lookUpSiteType);
            this.Controls.Add(this.lookUpCity);
            this.Controls.Add(this.lookUpProvince);
            this.Controls.Add(this.cheAllowArrears);
            this.Controls.Add(this.cheAllowCollection);
            this.Controls.Add(this.cheAllowArrivalPay);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtSendPlace);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSiteName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSiteEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "站点编辑";
            this.Load += new System.EventHandler(this.FrmSiteEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSiteType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowArrears.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowCollection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheAllowArrivalPay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSendPlace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOwnerSite.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.LookUpEdit lookUpCurrency;
        private DevExpress.XtraEditors.LookUpEdit lookUpSiteType;
        private DevExpress.XtraEditors.LookUpEdit lookUpCity;
        private DevExpress.XtraEditors.LookUpEdit lookUpProvince;
        private DevExpress.XtraEditors.CheckEdit cheAllowArrears;
        private DevExpress.XtraEditors.CheckEdit cheAllowCollection;
        private DevExpress.XtraEditors.CheckEdit cheAllowArrivalPay;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSendPlace;
        private DevExpress.XtraEditors.TextEdit txtArea;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSiteName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOwnerSite;
    }
}