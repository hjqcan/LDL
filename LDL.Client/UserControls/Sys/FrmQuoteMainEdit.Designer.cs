namespace LDL.Client.UserControls.Sys
{
    partial class FrmQuoteMainEdit
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxLogisticsType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxDispatchType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lsbCustomers = new DevExpress.XtraEditors.ListBoxControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lsbSite = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lsbDestination = new DevExpress.XtraEditors.ListBoxControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSortID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCondition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpression = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator = new DevExpress.XtraEditors.ControlNavigator();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lnkCheckExpression = new System.Windows.Forms.LinkLabel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditWeight = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cbxFeeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLogisticsType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDispatchType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsbCustomers)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsbSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsbDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFeeType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "报价名称";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "请输入报价名称";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.txtName, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "快件类型";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "派送方式";
            // 
            // cbxLogisticsType
            // 
            this.cbxLogisticsType.Location = new System.Drawing.Point(71, 65);
            this.cbxLogisticsType.Name = "cbxLogisticsType";
            this.cbxLogisticsType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLogisticsType.Properties.Items.AddRange(new object[] {
            "快件出口",
            "一般贸易出口",
            "进口快件",
            "小件"});
            this.cbxLogisticsType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLogisticsType.Size = new System.Drawing.Size(190, 20);
            this.cbxLogisticsType.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "请选择快件类型";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.cbxLogisticsType, conditionValidationRule2);
            // 
            // cbxDispatchType
            // 
            this.cbxDispatchType.Location = new System.Drawing.Point(71, 93);
            this.cbxDispatchType.Name = "cbxDispatchType";
            this.cbxDispatchType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDispatchType.Properties.Items.AddRange(new object[] {
            "派送",
            "自提"});
            this.cbxDispatchType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDispatchType.Size = new System.Drawing.Size(190, 20);
            this.cbxDispatchType.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "请选择派送方式";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.cbxDispatchType, conditionValidationRule3);
            // 
            // lsbCustomers
            // 
            this.lsbCustomers.ContextMenuStrip = this.contextMenu;
            this.lsbCustomers.DisplayMember = "Name";
            this.lsbCustomers.Location = new System.Drawing.Point(346, 9);
            this.lsbCustomers.Name = "lsbCustomers";
            this.lsbCustomers.Size = new System.Drawing.Size(190, 101);
            this.lsbCustomers.TabIndex = 4;
            this.lsbCustomers.Tag = "报价客户";
            this.lsbCustomers.ToolTip = "右键“新增”或“删除”操作";
            this.lsbCustomers.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.lsbCustomers.ToolTipTitle = "提示";
            this.lsbCustomers.ValueMember = "ID";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemDelete});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(98, 22);
            this.menuItemAdd.Text = "新增";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(98, 22);
            this.menuItemDelete.Text = "删除";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(292, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "报价客户";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 124);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "寄件站点";
            // 
            // lsbSite
            // 
            this.lsbSite.ContextMenuStrip = this.contextMenu;
            this.lsbSite.DisplayMember = "Name";
            this.lsbSite.Location = new System.Drawing.Point(71, 124);
            this.lsbSite.Name = "lsbSite";
            this.lsbSite.Size = new System.Drawing.Size(190, 81);
            this.lsbSite.TabIndex = 5;
            this.lsbSite.Tag = "寄件站点";
            this.lsbSite.ToolTip = "右键“新增”或“删除”操作";
            this.lsbSite.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.lsbSite.ToolTipTitle = "提示";
            this.lsbSite.ValueMember = "ID";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(292, 124);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "派件区域";
            // 
            // lsbDestination
            // 
            this.lsbDestination.ContextMenuStrip = this.contextMenu;
            this.lsbDestination.DisplayMember = "Name";
            this.lsbDestination.Location = new System.Drawing.Point(346, 124);
            this.lsbDestination.Name = "lsbDestination";
            this.lsbDestination.Size = new System.Drawing.Size(190, 81);
            this.lsbDestination.TabIndex = 6;
            this.lsbDestination.Tag = "派件区域";
            this.lsbDestination.ToolTip = "右键“新增”或“删除”操作";
            this.lsbDestination.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.lsbDestination.ToolTipTitle = "提示";
            this.lsbDestination.ValueMember = "ID";
            // 
            // gridData
            // 
            this.gridData.Location = new System.Drawing.Point(0, 244);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(559, 187);
            this.gridData.TabIndex = 13;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSortID,
            this.colCondition,
            this.colExpression});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvData.OptionsCustomization.AllowColumnMoving = false;
            this.gvData.OptionsCustomization.AllowFilter = false;
            this.gvData.OptionsCustomization.AllowGroup = false;
            this.gvData.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvData.OptionsMenu.EnableColumnMenu = false;
            this.gvData.OptionsNavigation.AutoFocusNewRow = true;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colSortID
            // 
            this.colSortID.AppearanceCell.Options.UseTextOptions = true;
            this.colSortID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSortID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSortID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSortID.Caption = "顺序";
            this.colSortID.FieldName = "SortID";
            this.colSortID.Name = "colSortID";
            this.colSortID.Visible = true;
            this.colSortID.VisibleIndex = 0;
            this.colSortID.Width = 40;
            // 
            // colCondition
            // 
            this.colCondition.AppearanceHeader.Options.UseTextOptions = true;
            this.colCondition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCondition.Caption = "条件公式";
            this.colCondition.FieldName = "Condition";
            this.colCondition.Name = "colCondition";
            this.colCondition.Visible = true;
            this.colCondition.VisibleIndex = 1;
            this.colCondition.Width = 150;
            // 
            // colExpression
            // 
            this.colExpression.AppearanceHeader.Options.UseTextOptions = true;
            this.colExpression.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExpression.Caption = "计算公式";
            this.colExpression.FieldName = "Expression";
            this.colExpression.Name = "colExpression";
            this.colExpression.Visible = true;
            this.colExpression.VisibleIndex = 2;
            this.colExpression.Width = 150;
            // 
            // controlNavigator
            // 
            this.controlNavigator.Location = new System.Drawing.Point(0, 220);
            this.controlNavigator.Name = "controlNavigator";
            this.controlNavigator.NavigatableControl = this.gridData;
            this.controlNavigator.Size = new System.Drawing.Size(261, 24);
            this.controlNavigator.TabIndex = 14;
            this.controlNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator_ButtonClick);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(443, 225);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 14);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "*注：w 代表重量";
            // 
            // lnkCheckExpression
            // 
            this.lnkCheckExpression.AutoSize = true;
            this.lnkCheckExpression.Location = new System.Drawing.Point(289, 224);
            this.lnkCheckExpression.Name = "lnkCheckExpression";
            this.lnkCheckExpression.Size = new System.Drawing.Size(55, 14);
            this.lnkCheckExpression.TabIndex = 16;
            this.lnkCheckExpression.TabStop = true;
            this.lnkCheckExpression.Text = "检验公式";
            this.lnkCheckExpression.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheckExpression_LinkClicked);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(346, 224);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(19, 14);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "w=";
            // 
            // spinEditWeight
            // 
            this.spinEditWeight.EditValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinEditWeight.Location = new System.Drawing.Point(366, 222);
            this.spinEditWeight.Name = "spinEditWeight";
            this.spinEditWeight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditWeight.Size = new System.Drawing.Size(48, 20);
            this.spinEditWeight.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl9.Location = new System.Drawing.Point(5, 409);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(547, 14);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "*条件公式符号含义：等于(==)、大于(>)、小于(<)、大于等于(>=)、小于等于(<=)、且(&&&&)、或(||)";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 432);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(559, 40);
            this.panelControl2.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::LDL.Client.Properties.Resources.Action_Save;
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(239, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxFeeType
            // 
            this.cbxFeeType.Location = new System.Drawing.Point(71, 37);
            this.cbxFeeType.Name = "cbxFeeType";
            this.cbxFeeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFeeType.Properties.Items.AddRange(new object[] {
            "中转费",
            "派件费"});
            this.cbxFeeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxFeeType.Size = new System.Drawing.Size(190, 20);
            this.cbxFeeType.TabIndex = 22;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "请选择费用类型";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validationProvider.SetValidationRule(this.cbxFeeType, conditionValidationRule4);
            this.cbxFeeType.SelectedIndexChanged += new System.EventHandler(this.cbxFeeType_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(17, 40);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 14);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "费用类型";
            // 
            // FrmQuoteMainEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 472);
            this.Controls.Add(this.cbxFeeType);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.spinEditWeight);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lnkCheckExpression);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.cbxDispatchType);
            this.Controls.Add(this.lsbDestination);
            this.Controls.Add(this.controlNavigator);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lsbSite);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lsbCustomers);
            this.Controls.Add(this.cbxLogisticsType);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuoteMainEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报价设置";
            this.Load += new System.EventHandler(this.FrmQuoteMainEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLogisticsType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDispatchType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsbCustomers)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lsbSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsbDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFeeType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLogisticsType;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDispatchType;
        private DevExpress.XtraEditors.ListBoxControl lsbCustomers;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ListBoxControl lsbSite;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ListBoxControl lsbDestination;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colSortID;
        private DevExpress.XtraGrid.Columns.GridColumn colCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colExpression;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.LinkLabel lnkCheckExpression;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit spinEditWeight;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.ComboBoxEdit cbxFeeType;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}