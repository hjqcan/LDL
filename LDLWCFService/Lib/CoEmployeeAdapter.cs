using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoEmployeeAdapter
    {
        /// <summary>
        /// 获取员工列表
        /// </summary>
        public static List<CoEmployee> GetEmployeeList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoEmployee.ToList();
        }

        /// <summary>
        /// 按员工编号获取员工
        /// </summary>
        public static CoEmployee GetEmployee(int id)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoEmployee.FirstOrDefault(obj => obj.ID == id && obj.Valid == true);
        }

        /// <summary>
        /// 按部门获取员工
        /// </summary>
        public static List<CoEmployee> GetEmployeeByDepartment(int deptID)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoEmployee.Where(obj => obj.DeptID == deptID && obj.Valid == true).ToList();
        }

        /// <summary>
        /// 新增员工
        /// </summary>
        public static void Insert(CoEmployee employee)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该员工是否存在
                if (context.CoEmployee.FirstOrDefault(obj => obj.Code.Trim().ToLower() == employee.Code.Trim().ToLower() && obj.Valid == true) != null)
                    throw new FaultException(string.Format("员工编号[{0}]已存在！", employee.Code));
                context.CoEmployee.AddObject(employee);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoEmployeeAdapter01", Define.Insert, employee));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 新增员工，与用户
        /// </summary>
        public static void InsertWithUser(CoEmployee employee, SysUser user)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该员工是否存在
                context.CoEmployee.Any(obj => obj.Valid == true);
                if (context.CoEmployee.FirstOrDefault(obj => obj.Code.Trim().ToLower() == employee.Code.Trim().ToLower() && obj.Valid == true) != null)
                    throw new FaultException(string.Format("员工编号[{0}]已存在！", employee.Code));
                context.CoEmployee.AddObject(employee);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoEmployeeAdapter02", Define.Insert, employee));   //记录日志
                //查找该用户是否存在
                if (context.SysUser.FirstOrDefault(obj => obj.UserName.Trim().ToLower() == user.UserName.Trim().ToLower()) != null)
                    throw new FaultException(string.Format("用户名[{0}]已存在！", user.UserName));
                context.SysUser.AddObject(user);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoEmployeeAdapter03", Define.Insert, user));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除员工
        /// </summary>
        public static void Delete(CoEmployee employee, bool delUser)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该员工是否存在
                CoEmployee _employee = context.CoEmployee.FirstOrDefault(obj => obj.ID == employee.ID);
                if (_employee == null)
                    throw new FaultException(string.Format("该员工[{0}]不存在！", employee.Name));
                EntityObjectHelper.Copyto(employee, ref _employee); //利用反射动态赋值
                if (delUser)
                {
                    SysUser user = context.SysUser.FirstOrDefault(obj => obj.EmployeeID == employee.ID);
                    if (user != null)
                        context.SysUser.DeleteObject(user);
                    context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoEmployeeAdapter04", Define.Delete, user));   //记录日志
                }
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoEmployeeAdapter05", Define.Delete, employee));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改员工
        /// </summary>
        public static void Update(CoEmployee employee)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该员工是否存在
                CoEmployee _employee = context.CoEmployee.FirstOrDefault(obj => obj.ID == employee.ID);
                if (_employee == null)
                    throw new FaultException(string.Format("该员工[{0}]不存在！", employee.Name));
                EntityObjectHelper.Copyto(employee, ref _employee); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoEmployeeAdapter06", Define.Update, _employee));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
