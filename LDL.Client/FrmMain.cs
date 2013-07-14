using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using LDL.Client.EF;
using LDL.Client.Common;
using LDL.Client.LDLService;
using System.Reflection;
using DevExpress.XtraTab;


namespace LDL.Client
{
    public partial class FrmMain : XtraForm
    {
        #region 工具栏属性
        public static DevExpress.XtraBars.BarManager _barManager;
        public static DevExpress.XtraBars.BarButtonItem _barbtnQuery;
        public static DevExpress.XtraBars.BarButtonItem _barbtnInsert;
        public static DevExpress.XtraBars.BarButtonItem _barbtnUpdate;
        public static DevExpress.XtraBars.BarButtonItem _barbtnDelete;
        public static DevExpress.XtraBars.BarButtonItem _barbtnSave;
        public static DevExpress.XtraBars.BarButtonItem _barbtnImport;
        public static DevExpress.XtraBars.BarButtonItem _barbtnExport;
        public static DevExpress.XtraBars.BarButtonItem _barbtnPrint;
        #endregion

        public FrmMain()
        {
            InitializeComponent();
            this.Text += "   欢迎您:" + Identity.CurrentUser.UserName;
            InitSkinGallery();
            ribbonControl.Minimized = true;

            InitToolbar();
            InitFunction();
        }

        #region 事件

        //关闭窗口
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ControlsHelper.ShowConfirmMessage("确认", "确定要关闭程序吗？") == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //主题变更
        private void rgbiSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                LocalStoreHelper.SetUserSetting("SkinName", e.Item.Tag.ToString());
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("保存配置信息失败", ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        //创建tab
        private void navBarControl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SysFunction func = (SysFunction)e.Link.Item.Tag;
                if (func.ControlType.ToString() != "")
                {
                    XtraTabPage tabPage = tabControl.TabPages.FirstOrDefault(obj => obj.Name == "tab_" + func.Code);
                    if (tabPage == null)
                    {
                        //创建TabPage
                        XtraUserControl control = (XtraUserControl)(Type.GetType(func.ControlType).GetConstructor(new Type[0]).Invoke(new object[0]));
                        control.Name = "uc_" + func.Code;
                        SysRoleFunction userFuction = Identity.CurrentUserFunction.Find(obj => obj.FunctionCode == func.Code);
                        control.Tag = userFuction;
                        tabPage = new XtraTabPage();
                        tabPage.Text = func.Name;
                        tabPage.Name = "tab_" + func.Code;
                        control.Dock = DockStyle.Fill;
                        tabPage.Controls.Add(control);
                        tabControl.TabPages.Add(tabPage);
                    }

                    tabControl.SelectedTabPage = tabPage;
                }
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("创建窗口失败", ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        //关闭
        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabPage tabPage = tabControl.SelectedTabPage;
            tabPage.Controls.Clear();
            tabControl.TabPages.Remove(tabPage);
            if (tabControl.TabPages.Count > 0)
            {
                Control control = tabControl.SelectedTabPage.Controls[0];
                MethodInfo method = control.GetType().GetMethod("InitToolbar");
                method.Invoke(control, new object[0]);
            }
        }


        //初始化工具栏
        private void tabControl_SelectedPageChanging(object sender, TabPageChangingEventArgs e)
        {
            Control control = e.Page.Controls[0];
            MethodInfo method = control.GetType().GetMethod("InitToolbar");
            method.Invoke(control, new object[0]);
        }

        #endregion

        #region 方法

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        void InitFunction()
        {
            List<SysFunction> lstFunction = Identity.CurrentFunction.OrderBy(obj => obj.OrderID).ToList();
            //组
            foreach (SysFunction func in lstFunction)
            {
                if (!lstFunction.Exists(obj => obj.Code == func.ParentCode))
                {
                    DevExpress.XtraNavBar.NavBarGroup group = new DevExpress.XtraNavBar.NavBarGroup();
                    group.Caption = func.Name;
                    group.Name = func.Code;
                    navBarControl.Groups.Add(group);
                    //子项
                    List<SysFunction> lstItemFunction = lstFunction.FindAll(obj => obj.ParentCode == func.Code);
                    foreach (SysFunction f in lstItemFunction)
                    {
                        DevExpress.XtraNavBar.NavBarItem item = new DevExpress.XtraNavBar.NavBarItem();
                        item.Caption = f.Name;
                        item.Name = f.Code;
                        item.Tag = f;
                        group.ItemLinks.Add(item);
                    }
                }
            }
            //展开
            if (navBarControl.Groups.Count > 0)
            {
                navBarControl.Groups[0].Expanded = true;
            }
        }

        void InitToolbar()
        {
            _barManager = barManager;
            _barbtnQuery = barbtnQuery;
            _barbtnInsert = barbtnInsert;
            _barbtnUpdate = barbtnUpdate;
            _barbtnDelete = barbtnDelete;
            _barbtnSave = barbtnSave;
            _barbtnImport = barbtnImport;
            _barbtnExport = barbtnExport;
            _barbtnPrint = barbtnPrint;
        }

        #endregion

        

       

        


    }
}