namespace LDL.Client.UserControls.Common
{
    partial class FrmDepartment
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
            this.treeListDept = new DevExpress.XtraTreeList.TreeList();
            this.colDeptName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.riLinkDeptName = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkDeptName)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListDept
            // 
            this.treeListDept.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDeptName});
            this.treeListDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListDept.Location = new System.Drawing.Point(0, 0);
            this.treeListDept.Name = "treeListDept";
            this.treeListDept.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riLinkDeptName});
            this.treeListDept.Size = new System.Drawing.Size(484, 361);
            this.treeListDept.TabIndex = 2;
            // 
            // colDeptName
            // 
            this.colDeptName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeptName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeptName.Caption = "名称";
            this.colDeptName.ColumnEdit = this.riLinkDeptName;
            this.colDeptName.FieldName = "DeptName";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 0;
            // 
            // riLinkDeptName
            // 
            this.riLinkDeptName.AutoHeight = false;
            this.riLinkDeptName.Name = "riLinkDeptName";
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.treeListDept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择部门";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDepartment_FormClosing);
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riLinkDeptName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListDept;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeptName;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit riLinkDeptName;
    }
}