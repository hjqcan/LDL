using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDL.Client.EF;

namespace LDL.Client.Common
{
    public class LocalStoreHelper
    {
        static LocalStoreEntities _context;
        public static LocalStoreEntities Context
        {
            get
            {
                if (_context == null)
                    _context = new LocalStoreEntities("metadata=res://*/EF.LocalStoreModel.csdl|res://*/EF.LocalStoreModel.ssdl|res://*/EF.LocalStoreModel.msl;provider=System.Data.SqlServerCe.3.5;provider connection string=\"Data Source=|DataDirectory|\\LocalStore.sdf;Password=lhm.@mq7670$!;Persist Security Info=True\"");

                return _context;
            }
        }

        public static string GetUserSetting(string key)
        {
            UserSetting userSetting = Context.UserSetting.FirstOrDefault(obj => obj.Key == key);
            if (userSetting == null)
                return null;
            else
                return userSetting.Value;
        }

        public static void SetUserSetting(string key, string value)
        {
            UserSetting userSetting = Context.UserSetting.FirstOrDefault(obj => obj.Key == key);
            bool isExists = userSetting != null;
            if (!isExists)
            {
                userSetting = new UserSetting();
                userSetting.Key = key;
                userSetting.Value = value;
                Context.UserSetting.AddObject(userSetting);
            }
            else
            {
                userSetting.Value = value;
            }
            Context.SaveChanges();
        }
    }
}
