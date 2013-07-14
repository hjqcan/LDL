using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using LDLWCFService.Lib;
using LDLWCFService.EF;
using System.IO;

namespace LDLWCFService.Validator
{
    public class UserNamePasswordValidator : System.IdentityModel.Selectors.UserNamePasswordValidator
    {
        public SysUser CurrentUser;

        public override void Validate(string userName, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(userName))
                    throw new ArgumentNullException("用户名");
                if (string.IsNullOrEmpty(password))
                    throw new ArgumentNullException("密码");


                CurrentUser = SysUserAdapter.GetUser(userName);

                if (CurrentUser == null ||
                    !(CurrentUser.UserName.Trim().ToLower() == userName.Trim().ToLower() && CurrentUser.Password == password))
                {
                    throw new FaultException("用户名或者密码错误！");
                }
                if (CurrentUser.IsLock)
                {
                    throw new FaultException("账号已被锁定！");
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
