using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class SysFunctionAdapter
    {
        public static List<SysFunction> GetFunctionList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysFunction.ToList();
        }

        /// <summary>
        /// 新增菜单
        /// </summary>
        public static void Insert(SysFunction function)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该菜单是否存在
                if (context.SysFunction.FirstOrDefault(obj => obj.Code == function.Code) != null)
                    throw new FaultException(string.Format("菜单编码[{0}]已存在！", function.Code));
                context.SysFunction.AddObject(function);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysFunctionAdapter01", Define.Insert, function));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="userName"></param>
        public static void Delete(string code)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                SysFunction function = context.SysFunction.FirstOrDefault(obj => obj.Code == code);
                if (function == null)
                    throw new FaultException(string.Format("菜单[{0}]不存在！", code));
                context.SysFunction.DeleteObject(function); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysFunctionAdapter02", Define.Delete, function));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        public static void Update(SysFunction function)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                SysFunction _function = context.SysFunction.FirstOrDefault(obj => obj.Code == function.Code);
                if (_function == null)
                    throw new FaultException(string.Format("菜单[{0}]不存在！", function.Name));
                EntityObjectHelper.Copyto(function, ref _function); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysFunctionAdapter03", Define.Update, _function));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        //public static List<SysFunction> GetFunctionByUserName(string userName)
        //{
        //    LDLLogisticsEntities context = new LDLLogisticsEntities();
        //    List<string> lstUserFunction = context.SysUserFunction.Where(obj => obj.UserName == userName).ToList().
        //        ConvertAll<string>(obj => obj.FunctionCode);
        //    return context.SysFunction.Where(obj => obj.Valid && lstUserFunction.Contains(obj.Code)).ToList();
        //}

        /// <summary>
        /// 获取菜单列表
        /// </summary>
        public static List<SysFunction> GetFunctionByRole(string roleCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            List<string> lstUserFunction = context.SysRoleFunction.Where(obj => obj.RoleCode.Trim().ToLower() == roleCode.Trim().ToLower()).ToList().
                ConvertAll<string>(obj => obj.FunctionCode);
            return context.SysFunction.Where(obj => obj.Valid && lstUserFunction.Contains(obj.Code)).OrderBy(obj => obj.OrderID).ToList();
        }
    }
}
