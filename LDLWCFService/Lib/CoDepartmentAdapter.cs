using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoDepartmentAdapter
    {
        /// <summary>
        /// 获取部门列表
        /// </summary>
        public static List<CoDepartment> GetDepartmentList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoDepartment.ToList();
        }

        /// <summary>
        /// 新增部门
        /// </summary>
        public static void Insert(CoDepartment dept)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该部门是否存在
                if (context.CoDepartment.Any(obj => obj.DeptCode == dept.DeptCode && obj.Valid == true))
                    throw new FaultException(string.Format("部门编码[{0}]已存在！", dept.DeptCode));
                context.CoDepartment.AddObject(dept);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDepartmentAdapter01", Define.Insert, dept));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        /// <summary>
        /// 删除部门
        /// </summary>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该部门是否存在
                CoDepartment dept = context.CoDepartment.FirstOrDefault(obj => obj.ID == id);
                if (dept == null)
                    throw new FaultException(string.Format("部门不存在！"));
                context.CoDepartment.DeleteObject(dept); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDepartmentAdapter02", Define.Delete, dept));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        public static void Update(CoDepartment dept)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该部门是否存在
                CoDepartment _dept = context.CoDepartment.FirstOrDefault(obj => obj.ID == dept.ID);
                if (_dept == null)
                    throw new FaultException(string.Format("该部门不存在！"));
                EntityObjectHelper.Copyto(dept, ref _dept); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDepartmentAdapter03", Define.Update, _dept));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
