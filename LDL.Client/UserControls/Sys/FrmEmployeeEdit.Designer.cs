namespace LDL.Client.UserControls.Sys
{
    partial class FrmEmployeeEdit
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btneditDepartment = new DevExpress.XtraEditors.ButtonEdit();
            this.btneditSite = new DevExpress.XtraEditors.ButtonEdit();
            this.txtEmployeeName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmployeeCode = new DevExpress.XtraEditors.TextEdit();
            this.txtQueryWord = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpSuperior = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEmployeeType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSuperior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmployeeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneditDepartment
            // 
            this.btneditDepartment.Location = new System.Drawing.Point(69, 44);
            this.btneditDepartment.Name = "btneditDepartment";
            this.btneditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneditDepartment.Size = new System.Drawing.Size(100, 20);
            this.btneditDepartment.TabIndex = 62;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "所属部门不能为空";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.btneditDepartment, conditionValidationRule5);
            // 
            // btneditSite
            // 
            this.btneditSite.Location = new System.Drawing.Point(238, 44);
            this.btneditSite.Name = "btneditSite";
            this.btneditSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneditSite.Size = new System.Drawing.Size(100, 20);
            this.btneditSite.TabIndex = 63;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "所属站点不能为空";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.btneditSite, conditionValidationRule1);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(238, 18);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 60;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "员工姓名不能为空";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtEmployeeName, conditionValidationRule2);
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(69, 18);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCode.TabIndex = 59;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "员工编号不能为空";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtEmployeeCode, conditionValidationRule3);
            // 
            // txtQueryWord
            // 
            this.txtQueryWord.Location = new System.Drawing.Point(417, 70);
            this.txtQueryWord.Name = "txtQueryWord";
            this.txtQueryWord.Size = new System.Drawing.Size(100, 20);
            this.txtQueryWord.TabIndex = 67;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(363, 73);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 14);
            this.labelControl11.TabIndex = 81;
            this.labelControl11.Text = "查询简写";
            // 
            // txtBarPassword
            // 
            this.txtBarPassword.Location = new System.Drawing.Point(238, 70);
            this.txtBarPassword.Name = "txtBarPassword";
            this.txtBarPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBarPassword.TabIndex = 66;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(184, 73);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 14);
            this.labelControl10.TabIndex = 80;
            this.labelControl10.Text = "巴枪密码";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(69, 70);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 65;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(17, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 79;
            this.labelControl9.Text = "联系电话";
            // 
            // lookUpSuperior
            // 
            this.lookUpSuperior.Location = new System.Drawing.Point(417, 44);
            this.lookUpSuperior.Name = "lookUpSuperior";
            this.lookUpSuperior.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSuperior.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QueryWord", "查询简称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "姓名")});
            this.lookUpSuperior.Properties.DisplayMember = "Name";
            this.lookUpSuperior.Properties.NullText = "";
            this.lookUpSuperior.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpSuperior.Properties.ValueMember = "ID";
            this.lookUpSuperior.Size = new System.Drawing.Size(100, 20);
            this.lookUpSuperior.TabIndex = 64;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(363, 47);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 78;
            this.labelControl8.Text = "上级主管";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(351, 21);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 77;
            this.labelControl7.Text = "操作员类型";
            // 
            // lookUpEmployeeType
            // 
            this.lookUpEmployeeType.Location = new System.Drawing.Point(417, 18);
            this.lookUpEmployeeType.Name = "lookUpEmployeeType";
            this.lookUpEmployeeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmployeeType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "名称")});
            this.lookUpEmployeeType.Properties.DisplayMember = "DisplayName";
            this.lookUpEmployeeType.Properties.NullText = "";
            this.lookUpEmployeeType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEmployeeType.Properties.ValueMember = "Code";
            this.lookUpEmployeeType.Size = new System.Drawing.Size(100, 20);
            this.lookUpEmployeeType.TabIndex = 61;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(184, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 76;
            this.labelControl6.Text = "所属站点";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(41, 102);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 75;
            this.labelControl5.Text = "地址";
            // 
            // labelControl3
            // 
            this.labelControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl3.Location = new System.Drawing.Point(184, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 74;
            this.labelControl3.Text = "员工姓名";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(69, 125);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(448, 20);
            this.txtRemark.TabIndex = 69;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(41, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 73;
            this.labelControl4.Text = "备注";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 99);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(448, 20);
            this.txtAddress.TabIndex = 68;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 72;
            this.labelControl2.Text = "所属部门";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 163);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(540, 40);
            this.panelControl2.TabIndex = 71;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LDL.Client.Properties.Resources.Action_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(273, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(187, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "员工编号";
            // 
            // FrmEmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 203);
            this.Controls.Add(this.btneditDepartment);
            this.Controls.Add(this.btneditSite);
            this.Controls.Add(this.txtQueryWord);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtBarPassword);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lookUpSuperior);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lookUpEmployeeType);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployeeEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工编辑";
            this.Load += new System.EventHandler(this.FrmEmployeeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneditSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSuperior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmployeeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.ButtonEdit btneditDepartment;
        private DevExpress.XtraEditors.ButtonEdit btneditSite;
        private DevExpress.XtraEditors.TextEdit txtQueryWord;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtBarPassword;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpSuperior;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmployeeType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtEmployeeName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtEmployeeCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}