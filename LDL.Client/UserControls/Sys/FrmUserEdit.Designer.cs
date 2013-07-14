namespace LDL.Client.UserControls.Sys
{
    partial class FrmUserEdit
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lookUpRole = new DevExpress.XtraEditors.LookUpEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cheIsLock = new DevExpress.XtraEditors.CheckEdit();
            this.txtComputerCode = new DevExpress.XtraEditors.TextEdit();
            this.cheIsAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.cheCheckComputer = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsLock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheCheckComputer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(277, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 50;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "请输入密码";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtPassword, conditionValidationRule1);
            // 
            // lookUpRole
            // 
            this.lookUpRole.Location = new System.Drawing.Point(80, 45);
            this.lookUpRole.Name = "lookUpRole";
            this.lookUpRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "名称")});
            this.lookUpRole.Properties.DisplayMember = "RoleName";
            this.lookUpRole.Properties.NullText = "请选择";
            this.lookUpRole.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpRole.Properties.ValueMember = "RoleCode";
            this.lookUpRole.Size = new System.Drawing.Size(137, 20);
            this.lookUpRole.TabIndex = 51;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "请选择用户角色";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.lookUpRole, conditionValidationRule2);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(80, 17);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(137, 20);
            this.txtUserName.TabIndex = 49;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "请输入用户名";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtUserName, conditionValidationRule3);
            // 
            // lookUpEmployee
            // 
            this.lookUpEmployee.Location = new System.Drawing.Point(277, 45);
            this.lookUpEmployee.Name = "lookUpEmployee";
            this.lookUpEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QueryWord", "查询简称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "姓名")});
            this.lookUpEmployee.Properties.DisplayMember = "Name";
            this.lookUpEmployee.Properties.NullText = "";
            this.lookUpEmployee.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEmployee.Properties.ValueMember = "ID";
            this.lookUpEmployee.Size = new System.Drawing.Size(139, 20);
            this.lookUpEmployee.TabIndex = 64;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(223, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "所属员工";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "计算机标识";
            // 
            // labelControl3
            // 
            this.labelControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl3.Location = new System.Drawing.Point(247, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 61;
            this.labelControl3.Text = "密码";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(80, 126);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(336, 20);
            this.txtRemark.TabIndex = 57;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "备注";
            // 
            // cheIsLock
            // 
            this.cheIsLock.Location = new System.Drawing.Point(277, 71);
            this.cheIsLock.Name = "cheIsLock";
            this.cheIsLock.Properties.Caption = "是否锁定";
            this.cheIsLock.Size = new System.Drawing.Size(75, 19);
            this.cheIsLock.TabIndex = 53;
            // 
            // txtComputerCode
            // 
            this.txtComputerCode.Location = new System.Drawing.Point(80, 100);
            this.txtComputerCode.Name = "txtComputerCode";
            this.txtComputerCode.Size = new System.Drawing.Size(336, 20);
            this.txtComputerCode.TabIndex = 56;
            // 
            // cheIsAdmin
            // 
            this.cheIsAdmin.Location = new System.Drawing.Point(189, 71);
            this.cheIsAdmin.Name = "cheIsAdmin";
            this.cheIsAdmin.Properties.Caption = "是否管理员";
            this.cheIsAdmin.Size = new System.Drawing.Size(82, 19);
            this.cheIsAdmin.TabIndex = 54;
            // 
            // cheCheckComputer
            // 
            this.cheCheckComputer.Location = new System.Drawing.Point(78, 71);
            this.cheCheckComputer.Name = "cheCheckComputer";
            this.cheCheckComputer.Properties.Caption = "登陆验证计算机";
            this.cheCheckComputer.Size = new System.Drawing.Size(105, 19);
            this.cheCheckComputer.TabIndex = 52;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 59;
            this.labelControl2.Text = "用户角色";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 161);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(438, 40);
            this.panelControl2.TabIndex = 58;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::LDL.Client.Properties.Resources.Action_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(228, 8);
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
            this.btnSave.Location = new System.Drawing.Point(142, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "用户名";
            // 
            // FrmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 201);
            this.Controls.Add(this.lookUpEmployee);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cheIsLock);
            this.Controls.Add(this.txtComputerCode);
            this.Controls.Add(this.cheIsAdmin);
            this.Controls.Add(this.cheCheckComputer);
            this.Controls.Add(this.lookUpRole);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户编辑";
            this.Load += new System.EventHandler(this.FrmUserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsLock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComputerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheIsAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheCheckComputer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.LookUpEdit lookUpEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit cheIsLock;
        private DevExpress.XtraEditors.TextEdit txtComputerCode;
        private DevExpress.XtraEditors.CheckEdit cheIsAdmin;
        private DevExpress.XtraEditors.CheckEdit cheCheckComputer;
        private DevExpress.XtraEditors.LookUpEdit lookUpRole;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}