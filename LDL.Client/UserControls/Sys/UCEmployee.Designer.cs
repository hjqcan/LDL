namespace LDL.Client.UserControls.Sys
{
    partial class UCEmployee
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpDeptCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSiteCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpSite = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpEmployeeType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSuperior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpSuperior = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.rilueRoleCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.riLinkRoleFunction = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.riLinkSite = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colSiteName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.riLinkDept = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colDeptName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpDeptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEmployeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueRoleCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkDept)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 570);
            this.panelControl1.TabIndex = 5;
            // 
            // gridData
            // 
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(2, 2);
            this.gridData.MainView = this.gvData;
            this.gridData.Name = "gridData";
            this.gridData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.rilueRoleCode,
            this.riLinkRoleFunction,
            this.riLookUpDeptCode,
            this.riLookUpSite,
            this.riLookUpEmployeeType,
            this.riLookUpSuperior});
            this.gridData.Size = new System.Drawing.Size(989, 566);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeCode,
            this.colEmployeeName,
            this.colDeptCode,
            this.colSiteCode,
            this.colEmployeeType,
            this.colSuperior,
            this.colPhone,
            this.colAddress,
            this.colBarPassword,
            this.colRemark,
            this.colValid});
            this.gvData.GridControl = this.gridData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvData.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeCode.Caption = "员工编号";
            this.colEmployeeCode.FieldName = "Code";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.OptionsColumn.ReadOnly = true;
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 0;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeName.Caption = "员工姓名";
            this.colEmployeeName.FieldName = "Name";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.OptionsColumn.ReadOnly = true;
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 1;
            // 
            // colDeptCode
            // 
            this.colDeptCode.AppearanceCell.Options.UseTextOptions = true;
            this.colDeptCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeptCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeptCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeptCode.Caption = "所属部门";
            this.colDeptCode.ColumnEdit = this.riLookUpDeptCode;
            this.colDeptCode.FieldName = "DeptID";
            this.colDeptCode.Name = "colDeptCode";
            this.colDeptCode.OptionsColumn.ReadOnly = true;
            this.colDeptCode.Visible = true;
            this.colDeptCode.VisibleIndex = 2;
            // 
            // riLookUpDeptCode
            // 
            this.riLookUpDeptCode.AutoHeight = false;
            this.riLookUpDeptCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpDeptCode.DisplayMember = "DeptName";
            this.riLookUpDeptCode.Name = "riLookUpDeptCode";
            this.riLookUpDeptCode.NullText = "";
            this.riLookUpDeptCode.ValueMember = "ID";
            // 
            // colSiteCode
            // 
            this.colSiteCode.AppearanceCell.Options.UseTextOptions = true;
            this.colSiteCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiteCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteCode.Caption = "所属站点";
            this.colSiteCode.ColumnEdit = this.riLookUpSite;
            this.colSiteCode.FieldName = "SiteID";
            this.colSiteCode.Name = "colSiteCode";
            this.colSiteCode.Visible = true;
            this.colSiteCode.VisibleIndex = 3;
            // 
            // riLookUpSite
            // 
            this.riLookUpSite.AutoHeight = false;
            this.riLookUpSite.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpSite.DisplayMember = "Name";
            this.riLookUpSite.Name = "riLookUpSite";
            this.riLookUpSite.NullText = "";
            this.riLookUpSite.ValueMember = "ID";
            // 
            // colEmployeeType
            // 
            this.colEmployeeType.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeType.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeType.Caption = "操作员类型";
            this.colEmployeeType.ColumnEdit = this.riLookUpEmployeeType;
            this.colEmployeeType.FieldName = "Type";
            this.colEmployeeType.Name = "colEmployeeType";
            this.colEmployeeType.Visible = true;
            this.colEmployeeType.VisibleIndex = 4;
            // 
            // riLookUpEmployeeType
            // 
            this.riLookUpEmployeeType.AutoHeight = false;
            this.riLookUpEmployeeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpEmployeeType.DisplayMember = "DisplayName";
            this.riLookUpEmployeeType.Name = "riLookUpEmployeeType";
            this.riLookUpEmployeeType.NullText = "";
            this.riLookUpEmployeeType.ValueMember = "Code";
            // 
            // colSuperior
            // 
            this.colSuperior.AppearanceCell.Options.UseTextOptions = true;
            this.colSuperior.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuperior.AppearanceHeader.Options.UseTextOptions = true;
            this.colSuperior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSuperior.Caption = "上级主管";
            this.colSuperior.ColumnEdit = this.riLookUpSuperior;
            this.colSuperior.FieldName = "Superior";
            this.colSuperior.Name = "colSuperior";
            this.colSuperior.Visible = true;
            this.colSuperior.VisibleIndex = 5;
            // 
            // riLookUpSuperior
            // 
            this.riLookUpSuperior.AutoHeight = false;
            this.riLookUpSuperior.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpSuperior.DisplayMember = "Name";
            this.riLookUpSuperior.Name = "riLookUpSuperior";
            this.riLookUpSuperior.NullText = "";
            this.riLookUpSuperior.ValueMember = "ID";
            // 
            // colPhone
            // 
            this.colPhone.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhone.Caption = "联系电话";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 6;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.Caption = "地址";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 7;
            // 
            // colBarPassword
            // 
            this.colBarPassword.AppearanceHeader.Options.UseTextOptions = true;
            this.colBarPassword.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarPassword.Caption = "巴枪密码";
            this.colBarPassword.FieldName = "BarPassword";
            this.colBarPassword.Name = "colBarPassword";
            this.colBarPassword.Visible = true;
            this.colBarPassword.VisibleIndex = 8;
            // 
            // colRemark
            // 
            this.colRemark.AppearanceHeader.Options.UseTextOptions = true;
            this.colRemark.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRemark.Caption = "备注";
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.OptionsColumn.ReadOnly = true;
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 9;
            // 
            // colValid
            // 
            this.colValid.AppearanceCell.Options.UseTextOptions = true;
            this.colValid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValid.AppearanceHeader.Options.UseTextOptions = true;
            this.colValid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValid.Caption = "是否可用";
            this.colValid.FieldName = "Valid";
            this.colValid.Name = "colValid";
            this.colValid.OptionsColumn.ReadOnly = true;
            this.colValid.Visible = true;
            this.colValid.VisibleIndex = 10;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "菜单功能";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "菜单功能";
            // 
            // rilueRoleCode
            // 
            this.rilueRoleCode.AutoHeight = false;
            this.rilueRoleCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueRoleCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "名称")});
            this.rilueRoleCode.DisplayMember = "RoleName";
            this.rilueRoleCode.Name = "rilueRoleCode";
            this.rilueRoleCode.NullText = "";
            this.rilueRoleCode.ValueMember = "RoleCode";
            // 
            // riLinkRoleFunction
            // 
            this.riLinkRoleFunction.AutoHeight = false;
            this.riLinkRoleFunction.Caption = "菜单功能";
            this.riLinkRoleFunction.Name = "riLinkRoleFunction";
            this.riLinkRoleFunction.NullText = "菜单功能";
            // 
            // riLinkSite
            // 
            this.riLinkSite.AutoHeight = false;
            this.riLinkSite.Name = "riLinkSite";
            // 
            // colSiteName
            // 
            this.colSiteName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiteName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiteName.Caption = "名称";
            this.colSiteName.ColumnEdit = this.riLinkSite;
            this.colSiteName.FieldName = "SiteName";
            this.colSiteName.Name = "colSiteName";
            this.colSiteName.Visible = true;
            this.colSiteName.VisibleIndex = 0;
            // 
            // riLinkDept
            // 
            this.riLinkDept.AutoHeight = false;
            this.riLinkDept.Name = "riLinkDept";
            // 
            // colDeptName
            // 
            this.colDeptName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeptName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeptName.Caption = "名称";
            this.colDeptName.ColumnEdit = this.riLinkDept;
            this.colDeptName.FieldName = "DeptName";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 0;
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(993, 570);
            this.Load += new System.EventHandler(this.UCEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpDeptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEmployeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueRoleCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkDept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueRoleCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn colSuperior;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBarPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colValid;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkRoleFunction;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpDeptCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpSite;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkSite;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSiteName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkDept;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeptName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpEmployeeType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpSuperior;
    }
}
