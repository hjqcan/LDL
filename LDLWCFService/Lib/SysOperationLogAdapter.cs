using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using LDLWCFService.Validator;
using System.ServiceModel;
using System.Data.Objects.DataClasses;
using LDL.Utility;

namespace LDLWCFService.Lib
{
    public class SysOperationLogAdapter
    {
        /// <summary>
        /// 获取操作记录对象
        /// </summary>
        /// <param name="operationType">INSERT|UPDATE|DELETE</param>
        public static SysOperationLog GetOperationtLog<T>(string operationID, string operationType, T obj) where T : EntityObject
        {
            UserNamePasswordValidator validator = (UserNamePasswordValidator)OperationContext.Current.Host.Credentials.UserNameAuthentication.CustomUserNamePasswordValidator;
            SysOperationLog log = new SysOperationLog();
            log.OperatorUserName = validator.CurrentUser.UserName;
            log.OperationID = operationID;
            log.OperationType = operationType;
            log.OperationTime = DateTime.Now;
            log.Details = JsonHelper.ObjectToJson(obj);
            return log;
        }

        /// <summary>
        /// 获取操作记录对象
        /// </summary>
        /// <param name="operationType">其它操作名称</param>
        public static SysOperationLog GetOperationtLog<T>(string operationID, string operationType, string details)
        {
            UserNamePasswordValidator validator = (UserNamePasswordValidator)OperationContext.Current.Host.Credentials.UserNameAuthentication.CustomUserNamePasswordValidator;
            SysOperationLog log = new SysOperationLog();
            log.OperatorUserName = validator.CurrentUser.UserName;
            log.OperationID = operationID;
            log.OperationType = operationType;
            log.OperationTime = DateTime.Now;
            log.Details = details;
            return log;
        }
    }
}
