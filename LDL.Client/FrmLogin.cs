using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.EF;
using LDL.Client.LDLService;
using LDL.Client.Common;
using LDL.Utility;

namespace LDL.Client
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region 事件

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            BindUserNameList();
            if (cbxUserName.Text != "")
                txtPwd.Focus();
        }

        private void cbxUserName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                try
                {
                    LoginUserName loginUserName = LocalStoreHelper.Context.LoginUserName.FirstOrDefault(obj => obj.UserName.ToLower() == cbxUserName.Text.Trim().ToLower());
                    if (loginUserName != null)
                    {
                        LocalStoreHelper.Context.DeleteObject(loginUserName);
                        LocalStoreHelper.Context.SaveChanges();
                        cbxUserName.Text = "";
                        BindUserNameList();
                    }
                }
                catch (Exception ex)
                {
                    ControlsHelper.ShowErrorMessage("删除账号信息失败", ex.Message);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cbxUserName.Text = cbxUserName.Text.Trim();
            if (cbxUserName.Text == "")
                return;

            this.Cursor = Cursors.WaitCursor;
            if (!Login())
            {
                this.Cursor = Cursors.Default;
                return;
            }

            //成功后
            if (ckbSaveUserName.Checked)
            {
                try
                {
                    LoginUserName loginUserName = LocalStoreHelper.Context.LoginUserName.FirstOrDefault(obj => obj.UserName.ToLower() == cbxUserName.Text.Trim().ToLower());
                    if (loginUserName != null)
                    {
                        loginUserName.LoginTime = DateTime.Now;
                    }
                    else
                    {
                        loginUserName = new LoginUserName();
                        loginUserName.UserName = cbxUserName.Text.Trim();
                        loginUserName.LoginTime = DateTime.Now;
                        LocalStoreHelper.Context.LoginUserName.AddObject(loginUserName);
                    }
                    LocalStoreHelper.Context.SaveChanges();
                    BindUserNameList();
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    ControlsHelper.ShowErrorMessage("保存账号信息失败", ex.Message);
                }
            }
            this.Cursor = Cursors.Default;
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
            
        }

        #endregion

        #region 方法

        void BindUserNameList()
        {
            try
            {
                List<LoginUserName> lstLoginUserName = LocalStoreHelper.Context.LoginUserName.OrderByDescending(obj => obj.LoginTime).ToList();
                cbxUserName.Properties.Items.Clear();
                foreach (LoginUserName l in lstLoginUserName)
                    cbxUserName.Properties.Items.Add(l.UserName);
                if (cbxUserName.Properties.Items.Count > 0)
                    cbxUserName.Text = cbxUserName.Properties.Items[0].ToString();
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("获取账号信息失败", ex.Message);
            }
        }

        bool Login()
        {
            WcfServiceClient client;
            try
            {
                client = new WcfServiceClient();
                client.ClientCredentials.UserName.UserName = cbxUserName.Text;
                client.ClientCredentials.UserName.Password = txtPwd.Text;
                client.SayHello(cbxUserName.Text);
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("登陆失败", ex.InnerException.Message);
                return false;
            }

            try
            {
                string macAddress = NetHelper.GetMacAddress();
                string ipAddress = NetHelper.GetIPAddress();
                string hostName = NetHelper.GetHostName();
                SysUser user = client.Login(macAddress, ipAddress, hostName);
                Identity.CurrentUser = user;
                Identity.LoadFunctionInfo();
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("登陆失败", ex.Message);
                return false;
            }

            return true;
        }

        #endregion

        
    }
}