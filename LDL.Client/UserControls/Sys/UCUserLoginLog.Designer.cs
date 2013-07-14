namespace LDL.Client.UserControls.Sys
{
    partial class UCUserLoginLog
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dateEditEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEditStartDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMacAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHostName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValidation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.validationNotBlank = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationNotBlank)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditEndDate
            // 
            this.dateEditEndDate.EditValue = null;
            this.dateEditEndDate.Location = new System.Drawing.Point(406, 31);
            this.dateEditEndDate.Name = "dateEditEndDate";
            this.dateEditEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditEndDate.Size = new System.Drawing.Size(100, 20);
            this.dateEditEndDate.TabIndex = 4;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.GreaterOrEqual;
            compareAgainstControlValidationRule1.Control = this.dateEditStartDate;
            compareAgainstControlValidationRule1.ErrorText = "结束日期必须大于等于开始日期";
            compareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.dateEditEndDate, compareAgainstControlValidationRule1);
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "结束日期不能为空";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationNotBlank.SetValidationRule(this.dateEditEndDate, conditionValidationRule2);
            // 
            // dateEditStartDate
            // 
            this.dateEditStartDate.EditValue = null;
            this.dateEditStartDate.Location = new System.Drawing.Point(284, 31);
            this.dateEditStartDate.Name = "dateEditStartDate";
            this.dateEditStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditStartDate.Size = new System.Drawing.Size(100, 20);
            this.dateEditStartDate.TabIndex = 3;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.LessOrEqual;
            compareAgainstControlValidationRule2.Control = this.dateEditEndDate;
            compareAgainstControlValidationRule2.ErrorText = "开始日期必须小于等于结束日期";
            compareAgainstControlValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.dateEditStartDate, compareAgainstControlValidationRule2);
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "开始日期不能为空";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationNotBlank.SetValidationRule(this.dateEditStartDate, conditionValidationRule1);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.labelControl3);
            this.groupControl.Controls.Add(this.dateEditEndDate);
            this.groupControl.Controls.Add(this.dateEditStartDate);
            this.groupControl.Controls.Add(this.labelControl2);
            this.groupControl.Controls.Add(this.txtUserName);
            this.groupControl.Controls.Add(this.labelControl1);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(864, 66);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "查询";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(390, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(9, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "~";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(230, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "登陆日期";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(58, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(130, 20);
            this.txtUserName.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "用户名不能为空";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationNotBlank.SetValidationRule(this.txtUserName, conditionValidationRule3);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(864, 481);
            this.panelControl1.TabIndex = 1;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(2, 2);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(860, 477);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colIPAddress,
            this.colMacAddress,
            this.colHostName,
            this.colLoginTime,
            this.colLoginState,
            this.colValidation});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvData_CustomColumnDisplayText);
            // 
            // colUserName
            // 
            this.colUserName.AppearanceCell.Options.UseTextOptions = true;
            this.colUserName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "用户名";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colIPAddress
            // 
            this.colIPAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colIPAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIPAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colIPAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIPAddress.Caption = "IP地址";
            this.colIPAddress.FieldName = "IPAddress";
            this.colIPAddress.Name = "colIPAddress";
            this.colIPAddress.OptionsColumn.ReadOnly = true;
            this.colIPAddress.Visible = true;
            this.colIPAddress.VisibleIndex = 1;
            // 
            // colMacAddress
            // 
            this.colMacAddress.AppearanceCell.Options.UseTextOptions = true;
            this.colMacAddress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMacAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colMacAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMacAddress.Caption = "MAC地址";
            this.colMacAddress.FieldName = "MacAddress";
            this.colMacAddress.Name = "colMacAddress";
            this.colMacAddress.OptionsColumn.ReadOnly = true;
            this.colMacAddress.Visible = true;
            this.colMacAddress.VisibleIndex = 2;
            // 
            // colHostName
            // 
            this.colHostName.AppearanceCell.Options.UseTextOptions = true;
            this.colHostName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHostName.AppearanceHeader.Options.UseTextOptions = true;
            this.colHostName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHostName.Caption = "主机名";
            this.colHostName.FieldName = "HostName";
            this.colHostName.Name = "colHostName";
            this.colHostName.OptionsColumn.ReadOnly = true;
            this.colHostName.Visible = true;
            this.colHostName.VisibleIndex = 3;
            // 
            // colLoginTime
            // 
            this.colLoginTime.AppearanceCell.Options.UseTextOptions = true;
            this.colLoginTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoginTime.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoginTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoginTime.Caption = "登陆时间";
            this.colLoginTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm";
            this.colLoginTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLoginTime.FieldName = "LoginTime";
            this.colLoginTime.Name = "colLoginTime";
            this.colLoginTime.OptionsColumn.ReadOnly = true;
            this.colLoginTime.Visible = true;
            this.colLoginTime.VisibleIndex = 4;
            // 
            // colLoginState
            // 
            this.colLoginState.AppearanceCell.Options.UseTextOptions = true;
            this.colLoginState.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoginState.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoginState.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoginState.Caption = "登陆状态";
            this.colLoginState.FieldName = "LoginState";
            this.colLoginState.Name = "colLoginState";
            this.colLoginState.OptionsColumn.ReadOnly = true;
            this.colLoginState.Visible = true;
            this.colLoginState.VisibleIndex = 5;
            // 
            // colValidation
            // 
            this.colValidation.AppearanceCell.Options.UseTextOptions = true;
            this.colValidation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValidation.AppearanceHeader.Options.UseTextOptions = true;
            this.colValidation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValidation.Caption = "验证ID";
            this.colValidation.Name = "colValidation";
            this.colValidation.Visible = true;
            this.colValidation.VisibleIndex = 6;
            // 
            // UCUSerLoginLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl);
            this.Name = "UCUSerLoginLog";
            this.Size = new System.Drawing.Size(864, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationNotBlank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEditEndDate;
        private DevExpress.XtraEditors.DateEdit dateEditStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colIPAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colMacAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colHostName;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginTime;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginState;
        private DevExpress.XtraGrid.Columns.GridColumn colValidation;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationNotBlank;
    }
}
