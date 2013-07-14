using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;
using LDLWCFService.Validator;
using System.Security.Cryptography;
using LDL.Utility;

namespace LDLWCFService.Lib
{
    public class SysUserAdapter
    {
        /// <summary>
        /// 登陆
        /// </summary>
        public static SysUser Login(string macAddress, string ipAddress, string hostName)
        {
            try
            {
                UserNamePasswordValidator validator = (UserNamePasswordValidator)OperationContext.Current.Host.Credentials.UserNameAuthentication.CustomUserNamePasswordValidator;
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                SysUserLoginLog log = new SysUserLoginLog();
                log.MacAddress = macAddress;
                log.IPAddress = ipAddress;
                log.HostName = hostName;
                log.LoginTime = DateTime.Now;
                log.UserName = validator.CurrentUser.UserName;
                log.LoginState = "成功";
                context.SysUserLoginLog.AddObject(log);

                if (validator.CurrentUser.CheckComputer)
                {
                    string computerCode = SecurityHelper.MD5(macAddress + "|" + hostName);
                    if (!validator.CurrentUser.ComputerCode.Contains(computerCode))
                    {
                        log.LoginState = "失败";
                        context.SaveChanges();
                        throw new FaultException("请在指定的计算机上登陆！");
                    }
                }
                context.SaveChanges();
                return validator.CurrentUser;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        public static SysUser GetUser(string userName)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            //查找该用户是否存在
            SysUser user = context.SysUser.FirstOrDefault(obj => obj.UserName.Trim().ToLower() == userName.Trim().ToLower() && obj.Valid == true);
            if (user == null)
                throw new FaultException(string.Format("用户[{0}]不存在！", user.UserName));

            return user;
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        public static List<SysUser> GetUserList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysUser.ToList();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        public static void Insert(SysUser user)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                if (context.SysUser.FirstOrDefault(obj => obj.UserName.Trim().ToLower() == user.UserName.Trim().ToLower() && obj.Valid == true) != null)
                    throw new FaultException(string.Format("用户名[{0}]已存在！", user.UserName));
                context.SysUser.AddObject(user);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysUserAdapter01", Define.Insert, user));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userName"></param>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                SysUser user = context.SysUser.FirstOrDefault(obj => obj.ID == id );
                if (user == null)
                    throw new FaultException(string.Format("用户不存在！"));

                context.SysUser.DeleteObject(user); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysUserAdapter02", Define.Delete, user));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        public static void Update(SysUser user)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                SysUser _user = context.SysUser.FirstOrDefault(obj => obj.ID == user.ID);
                if (_user == null)
                    throw new FaultException(string.Format("该用户[{0}]不存在！", user.UserName));
                EntityObjectHelper.Copyto(user, ref _user); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysUserAdapter03", Define.Update, _user));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 获取用户对应的菜单列表
        /// </summary>
        public static List<SysUserFunction> GetUserFunction(int userId)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysUserFunction.Where(obj => obj.UserID == userId).ToList();
        }

        /// <summary>
        /// 获取用户登陆记录
        /// </summary>
        public static List<SysUserLoginLog> GetUserLoginLog(string userName, DateTime startTime, DateTime endTime)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysUserLoginLog.Where(
                obj => obj.UserName == userName && obj.LoginTime >= startTime && obj.LoginTime <= endTime).ToList();
        }
    }
}
