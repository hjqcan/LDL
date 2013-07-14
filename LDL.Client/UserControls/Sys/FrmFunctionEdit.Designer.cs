namespace LDL.Client.UserControls.Sys
{
    partial class FrmFunctionEdit
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.spinEditOrderID = new DevExpress.XtraEditors.SpinEdit();
            this.txtControlType = new DevExpress.XtraEditors.TextEdit();
            this.txtFunctionName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cheSave = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cheExport = new DevExpress.XtraEditors.CheckEdit();
            this.cheImport = new DevExpress.XtraEditors.CheckEdit();
            this.chePrint = new DevExpress.XtraEditors.CheckEdit();
            this.cheDelete = new DevExpress.XtraEditors.CheckEdit();
            this.cheUpdate = new DevExpress.XtraEditors.CheckEdit();
            this.cheInsert = new DevExpress.XtraEditors.CheckEdit();
            this.cheQuery = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControlType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFunctionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheSave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheExport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheDelete.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheInsert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheQuery.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(220, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(128, 20);
            this.txtCode.TabIndex = 21;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "编码不能为空";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtCode, conditionValidationRule1);
            // 
            // spinEditOrderID
            // 
            this.spinEditOrderID.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditOrderID.Location = new System.Drawing.Point(220, 38);
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
            this.spinEditOrderID.Size = new System.Drawing.Size(128, 20);
            this.spinEditOrderID.TabIndex = 23;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "排序不能为空";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.spinEditOrderID, conditionValidationRule2);
            // 
            // txtControlType
            // 
            this.txtControlType.Location = new System.Drawing.Point(42, 38);
            this.txtControlType.Name = "txtControlType";
            this.txtControlType.Size = new System.Drawing.Size(132, 20);
            this.txtControlType.TabIndex = 22;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "路径不能为空";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtControlType, conditionValidationRule3);
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Location = new System.Drawing.Point(42, 9);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(132, 20);
            this.txtFunctionName.TabIndex = 19;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "名称不能为空";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtFunctionName, conditionValidationRule4);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 122);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(366, 40);
            this.panelControl2.TabIndex = 34;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(87, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::LDL.Client.Properties.Resources.Action_Cancel;
            this.btnCancel.Location = new System.Drawing.Point(173, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cheSave
            // 
            this.cheSave.Location = new System.Drawing.Point(11, 89);
            this.cheSave.Name = "cheSave";
            this.cheSave.Properties.Caption = "保存功能";
            this.cheSave.Size = new System.Drawing.Size(75, 19);
            this.cheSave.TabIndex = 29;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(190, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "编码";
            // 
            // cheExport
            // 
            this.cheExport.Location = new System.Drawing.Point(278, 89);
            this.cheExport.Name = "cheExport";
            this.cheExport.Properties.Caption = "导出功能";
            this.cheExport.Size = new System.Drawing.Size(71, 19);
            this.cheExport.TabIndex = 32;
            // 
            // cheImport
            // 
            this.cheImport.Location = new System.Drawing.Point(189, 89);
            this.cheImport.Name = "cheImport";
            this.cheImport.Properties.Caption = "导入功能";
            this.cheImport.Size = new System.Drawing.Size(75, 19);
            this.cheImport.TabIndex = 31;
            // 
            // chePrint
            // 
            this.chePrint.Location = new System.Drawing.Point(100, 89);
            this.chePrint.Name = "chePrint";
            this.chePrint.Properties.Caption = "打印功能";
            this.chePrint.Size = new System.Drawing.Size(75, 19);
            this.chePrint.TabIndex = 30;
            // 
            // cheDelete
            // 
            this.cheDelete.Location = new System.Drawing.Point(278, 64);
            this.cheDelete.Name = "cheDelete";
            this.cheDelete.Properties.Caption = "删除功能";
            this.cheDelete.Size = new System.Drawing.Size(71, 19);
            this.cheDelete.TabIndex = 28;
            // 
            // cheUpdate
            // 
            this.cheUpdate.Location = new System.Drawing.Point(189, 64);
            this.cheUpdate.Name = "cheUpdate";
            this.cheUpdate.Properties.Caption = "修改功能";
            this.cheUpdate.Size = new System.Drawing.Size(75, 19);
            this.cheUpdate.TabIndex = 27;
            // 
            // cheInsert
            // 
            this.cheInsert.Location = new System.Drawing.Point(100, 64);
            this.cheInsert.Name = "cheInsert";
            this.cheInsert.Properties.Caption = "增加功能";
            this.cheInsert.Size = new System.Drawing.Size(75, 19);
            this.cheInsert.TabIndex = 26;
            // 
            // cheQuery
            // 
            this.cheQuery.Location = new System.Drawing.Point(11, 64);
            this.cheQuery.Name = "cheQuery";
            this.cheQuery.Properties.Caption = "查询功能";
            this.cheQuery.Size = new System.Drawing.Size(75, 19);
            this.cheQuery.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(190, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "排序";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "路径";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "名称";
            // 
            // FrmFunctionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 162);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.cheSave);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cheExport);
            this.Controls.Add(this.cheImport);
            this.Controls.Add(this.chePrint);
            this.Controls.Add(this.cheDelete);
            this.Controls.Add(this.cheUpdate);
            this.Controls.Add(this.cheInsert);
            this.Controls.Add(this.cheQuery);
            this.Controls.Add(this.spinEditOrderID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtControlType);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFunctionName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFunctionEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单编辑";
            this.Load += new System.EventHandler(this.FrmFunctionEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControlType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFunctionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cheSave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheExport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheDelete.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheInsert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheQuery.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.CheckEdit cheSave;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit cheExport;
        private DevExpress.XtraEditors.CheckEdit cheImport;
        private DevExpress.XtraEditors.CheckEdit chePrint;
        private DevExpress.XtraEditors.CheckEdit cheDelete;
        private DevExpress.XtraEditors.CheckEdit cheUpdate;
        private DevExpress.XtraEditors.CheckEdit cheInsert;
        private DevExpress.XtraEditors.CheckEdit cheQuery;
        private DevExpress.XtraEditors.SpinEdit spinEditOrderID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtControlType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFunctionName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}