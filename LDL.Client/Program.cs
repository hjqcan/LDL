using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Linq;
using LDL.Client.EF;
using LDL.Client.Common;

namespace LDL.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #region 初始化样式

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            string defaultSkin = "Office 2007 Blue";
            try
            {
                string skinName = LocalStoreHelper.GetUserSetting("SkinName");
                if (!string.IsNullOrEmpty(skinName))
                    defaultSkin = skinName;
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("读取配置文件失败", ex.Message);
            }

            UserLookAndFeel.Default.SetSkinStyle(defaultSkin);
            #endregion

            Application.Run(new FrmLogin());
        }
    }
}