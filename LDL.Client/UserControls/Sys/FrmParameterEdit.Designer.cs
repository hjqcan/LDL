namespace LDL.Client.UserControls.Sys
{
    partial class FrmParameterEdit
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditOrderID = new DevExpress.XtraEditors.SpinEdit();
            this.txtQueryWord = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtMark3 = new DevExpress.XtraEditors.TextEdit();
            this.txtMark2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMark1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 141);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(563, 40);
            this.panelControl2.TabIndex = 48;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::LDL.Client.Properties.Resources.Action_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(293, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(201, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // spinEditOrderID
            // 
            this.spinEditOrderID.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditOrderID.Location = new System.Drawing.Point(245, 104);
            this.spinEditOrderID.Name = "spinEditOrderID";
            this.spinEditOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditOrderID.Properties.IsFloatValue = false;
            this.spinEditOrderID.Properties.Mask.EditMask = "N00";
            this.spinEditOrderID.Properties.MaxLength = 1;
            this.spinEditOrderID.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spinEditOrderID.Size = new System.Drawing.Size(120, 20);
            this.spinEditOrderID.TabIndex = 39;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "排序不能为空";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.spinEditOrderID, conditionValidationRule3);
            // 
            // txtQueryWord
            // 
            this.txtQueryWord.Location = new System.Drawing.Point(68, 104);
            this.txtQueryWord.Name = "txtQueryWord";
            this.txtQueryWord.Properties.MaxLength = 20;
            this.txtQueryWord.Size = new System.Drawing.Size(120, 20);
            this.txtQueryWord.TabIndex = 38;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(14, 107);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 14);
            this.labelControl11.TabIndex = 47;
            this.labelControl11.Text = "查询简写";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(68, 73);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.MaxLength = 512;
            this.txtRemark.Size = new System.Drawing.Size(475, 20);
            this.txtRemark.TabIndex = 37;
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(423, 44);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Properties.MaxLength = 50;
            this.txtMark3.Size = new System.Drawing.Size(120, 20);
            this.txtMark3.TabIndex = 36;
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(245, 44);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Properties.MaxLength = 50;
            this.txtMark2.Size = new System.Drawing.Size(120, 20);
            this.txtMark2.TabIndex = 35;
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(68, 44);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Properties.MaxLength = 50;
            this.txtMark1.Size = new System.Drawing.Size(120, 20);
            this.txtMark1.TabIndex = 32;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(38, 76);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 14);
            this.labelControl10.TabIndex = 46;
            this.labelControl10.Text = "备注";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(386, 47);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 14);
            this.labelControl9.TabIndex = 45;
            this.labelControl9.Text = "标识3";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(208, 47);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 14);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "标识2";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(31, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 14);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "标识1";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(423, 15);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.MaxLength = 200;
            this.txtFullName.Size = new System.Drawing.Size(120, 20);
            this.txtFullName.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(393, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "全称";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(245, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.MaxLength = 20;
            this.txtCode.Size = new System.Drawing.Size(120, 20);
            this.txtCode.TabIndex = 30;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "编码不能为空";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtCode, conditionValidationRule4);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(215, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "编码";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(371, 107);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(0, 14);
            this.labelControl12.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(215, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "排序";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(68, 15);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Properties.MaxLength = 50;
            this.txtDisplayName.Size = new System.Drawing.Size(120, 20);
            this.txtDisplayName.TabIndex = 29;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "显示名称不能为空";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtDisplayName, conditionValidationRule1);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "显示名称";
            // 
            // FrmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 181);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.spinEditOrderID);
            this.Controls.Add(this.txtQueryWord);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtMark3);
            this.Controls.Add(this.txtMark2);
            this.Controls.Add(this.txtMark1);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParameter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数编辑";
            this.Load += new System.EventHandler(this.FrmParameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SpinEdit spinEditOrderID;
        private DevExpress.XtraEditors.TextEdit txtQueryWord;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtMark3;
        private DevExpress.XtraEditors.TextEdit txtMark2;
        private DevExpress.XtraEditors.TextEdit txtMark1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDisplayName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}