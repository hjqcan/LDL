namespace LDL.Client.UserControls.Sys
{
    partial class UCRole
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupHeader = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtRoleCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLinkRoleFunction = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.popupContainer = new DevExpress.XtraEditors.PopupContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupHeader)).BeginInit();
            this.groupHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer)).BeginInit();
            this.popupContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupHeader
            // 
            this.groupHeader.Controls.Add(this.panelControl2);
            this.groupHeader.Controls.Add(this.txtRoleCode);
            this.groupHeader.Controls.Add(this.labelControl4);
            this.groupHeader.Controls.Add(this.txtRoleName);
            this.groupHeader.Controls.Add(this.labelControl1);
            this.groupHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupHeader.Location = new System.Drawing.Point(2, 2);
            this.groupHeader.Name = "groupHeader";
            this.groupHeader.Size = new System.Drawing.Size(348, 113);
            this.groupHeader.TabIndex = 2;
            this.groupHeader.Text = "新增";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 71);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(344, 40);
            this.panelControl2.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LDL.Client.Properties.Resources.Action_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(175, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(89, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRoleCode
            // 
            this.txtRoleCode.Location = new System.Drawing.Point(59, 36);
            this.txtRoleCode.Name = "txtRoleCode";
            this.txtRoleCode.Size = new System.Drawing.Size(100, 20);
            this.txtRoleCode.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "编码不能为空";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtRoleCode, conditionValidationRule1);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "编码";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(205, 36);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(115, 20);
            this.txtRoleName.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "名称不能为空";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtRoleName, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(175, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "名称";
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
            this.riLinkRoleFunction});
            this.gridData.Size = new System.Drawing.Size(932, 498);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleCode,
            this.colRoleName,
            this.colCommand});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvData_RowCellClick);
            // 
            // colRoleCode
            // 
            this.colRoleCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleCode.Caption = "角色编码";
            this.colRoleCode.FieldName = "RoleCode";
            this.colRoleCode.Name = "colRoleCode";
            this.colRoleCode.OptionsColumn.ReadOnly = true;
            this.colRoleCode.Visible = true;
            this.colRoleCode.VisibleIndex = 0;
            // 
            // colRoleName
            // 
            this.colRoleName.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleName.Caption = "角色名称";
            this.colRoleName.FieldName = "RoleName";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.OptionsColumn.ReadOnly = true;
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            // 
            // colCommand
            // 
            this.colCommand.AppearanceCell.Options.UseTextOptions = true;
            this.colCommand.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommand.AppearanceHeader.Options.UseTextOptions = true;
            this.colCommand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCommand.Caption = "操作";
            this.colCommand.ColumnEdit = this.riLinkRoleFunction;
            this.colCommand.Name = "colCommand";
            this.colCommand.Visible = true;
            this.colCommand.VisibleIndex = 2;
            // 
            // riLinkRoleFunction
            // 
            this.riLinkRoleFunction.AutoHeight = false;
            this.riLinkRoleFunction.Caption = "菜单功能";
            this.riLinkRoleFunction.Name = "riLinkRoleFunction";
            this.riLinkRoleFunction.NullText = "菜单功能";
            // 
            // popupContainer
            // 
            this.popupContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.popupContainer.Controls.Add(this.groupHeader);
            this.popupContainer.Location = new System.Drawing.Point(268, 151);
            this.popupContainer.Name = "popupContainer";
            this.popupContainer.Size = new System.Drawing.Size(352, 117);
            this.popupContainer.TabIndex = 4;
            // 
            // UCRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popupContainer);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCRole";
            this.Size = new System.Drawing.Size(936, 502);
            ((System.ComponentModel.ISupportInitialize)(this.groupHeader)).EndInit();
            this.groupHeader.ResumeLayout(false);
            this.groupHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainer)).EndInit();
            this.popupContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupHeader;
        private DevExpress.XtraEditors.TextEdit txtRoleCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PopupContainerControl popupContainer;
        private DevExpress.XtraGrid.Columns.GridColumn colCommand;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkRoleFunction;
    }
}
