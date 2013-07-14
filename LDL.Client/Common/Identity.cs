using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDL.Client.LDLService;

namespace LDL.Client.Common
{
    public class Identity
    {
        public static SysUser CurrentUser;
        public static CoEmployee CurrentEmployee;
        public static List<SysRoleFunction> CurrentUserFunction;
        public static  List<SysFunction> CurrentFunction;

        public static void LoadFunctionInfo()
        {
            if (CurrentUser == null)
                throw new Exception("请先获取用户信息！");

            CurrentUserFunction = WcfServiceHelper.Client.GetRoleFunctionList(CurrentUser.RoleCode).ToList();
            CurrentFunction = WcfServiceHelper.Client.GetFunctionByRole(CurrentUser.RoleCode).ToList();
            if (CurrentUser.EmployeeID.HasValue)
                CurrentEmployee = WcfServiceHelper.Client.GetEmployee(CurrentUser.EmployeeID.Value);
        }
    }
}
