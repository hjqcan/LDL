namespace LDL.Client.UserControls.Sys
{
    partial class UCUser
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
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueRoleCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLookUpEditEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIsLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheckComputer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComputerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riLinkRoleFunction = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueRoleCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEditEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridData);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(932, 565);
            this.panelControl1.TabIndex = 4;
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
            this.riLookUpEditEmployee});
            this.gridData.Size = new System.Drawing.Size(928, 561);
            this.gridData.TabIndex = 0;
            this.gridData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colRoleCode,
            this.colEmployee,
            this.colIsLock,
            this.colIsAdmin,
            this.colCheckComputer,
            this.colComputerCode,
            this.colRemark,
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
            // colUserName
            // 
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "用户名";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colRoleCode
            // 
            this.colRoleCode.AppearanceCell.Options.UseTextOptions = true;
            this.colRoleCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colRoleCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRoleCode.Caption = "角色名称";
            this.colRoleCode.ColumnEdit = this.rilueRoleCode;
            this.colRoleCode.FieldName = "RoleCode";
            this.colRoleCode.Name = "colRoleCode";
            this.colRoleCode.OptionsColumn.ReadOnly = true;
            this.colRoleCode.Visible = true;
            this.colRoleCode.VisibleIndex = 1;
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
            // colEmployee
            // 
            this.colEmployee.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployee.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployee.Caption = "所属员工";
            this.colEmployee.ColumnEdit = this.riLookUpEditEmployee;
            this.colEmployee.FieldName = "EmployeeID";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 2;
            // 
            // riLookUpEditEmployee
            // 
            this.riLookUpEditEmployee.AutoHeight = false;
            this.riLookUpEditEmployee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riLookUpEditEmployee.DisplayMember = "Name";
            this.riLookUpEditEmployee.Name = "riLookUpEditEmployee";
            this.riLookUpEditEmployee.NullText = "";
            this.riLookUpEditEmployee.ValueMember = "ID";
            // 
            // colIsLock
            // 
            this.colIsLock.AppearanceCell.Options.UseTextOptions = true;
            this.colIsLock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsLock.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsLock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsLock.Caption = "是否锁定";
            this.colIsLock.FieldName = "IsLock";
            this.colIsLock.Name = "colIsLock";
            this.colIsLock.OptionsColumn.ReadOnly = true;
            this.colIsLock.Visible = true;
            this.colIsLock.VisibleIndex = 3;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.AppearanceCell.Options.UseTextOptions = true;
            this.colIsAdmin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsAdmin.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsAdmin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIsAdmin.Caption = "是否管理员";
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.OptionsColumn.ReadOnly = true;
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 4;
            // 
            // colCheckComputer
            // 
            this.colCheckComputer.AppearanceCell.Options.UseTextOptions = true;
            this.colCheckComputer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCheckComputer.AppearanceHeader.Options.UseTextOptions = true;
            this.colCheckComputer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCheckComputer.Caption = "登陆验证电脑ID";
            this.colCheckComputer.FieldName = "CheckComputer";
            this.colCheckComputer.Name = "colCheckComputer";
            this.colCheckComputer.OptionsColumn.ReadOnly = true;
            this.colCheckComputer.Visible = true;
            this.colCheckComputer.VisibleIndex = 5;
            // 
            // colComputerCode
            // 
            this.colComputerCode.AppearanceCell.Options.UseTextOptions = true;
            this.colComputerCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colComputerCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colComputerCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colComputerCode.Caption = "验证ID";
            this.colComputerCode.FieldName = "ComputerCode";
            this.colComputerCode.Name = "colComputerCode";
            this.colComputerCode.OptionsColumn.ReadOnly = true;
            this.colComputerCode.Visible = true;
            this.colComputerCode.VisibleIndex = 6;
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
            this.colRemark.VisibleIndex = 7;
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
            this.colCommand.VisibleIndex = 8;
            // 
            // riLinkRoleFunction
            // 
            this.riLinkRoleFunction.AutoHeight = false;
            this.riLinkRoleFunction.Caption = "菜单功能";
            this.riLinkRoleFunction.Name = "riLinkRoleFunction";
            this.riLinkRoleFunction.NullText = "菜单功能";
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Caption = "菜单功能";
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            this.repositoryItemHyperLinkEdit1.NullText = "菜单功能";
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(932, 565);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueRoleCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLookUpEditEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkRoleFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLock;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckComputer;
        private DevExpress.XtraGrid.Columns.GridColumn colComputerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueRoleCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCommand;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkRoleFunction;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riLookUpEditEmployee;
    }
}
