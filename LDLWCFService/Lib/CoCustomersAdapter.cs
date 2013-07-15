using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoCustomersAdapter
    {
        /// <summary>
        /// 获取客户列表
        /// </summary>
        public static List<CoCustomers> GetCustomersList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoCustomers.ToList();
        }

        /// <summary>
        /// 新增客户
        /// </summary>
        public static void Insert(CoCustomers customers)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该客户是否存在
                if (context.CoCustomers.Any(obj => obj.Code.Trim().ToLower() == customers.Code.Trim().ToLower() && obj.Valid == true))
                    throw new FaultException(string.Format("客户编码[{0}]已存在！", customers.Code));
                context.CoCustomers.AddObject(customers);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoCustomersAdapter01", Define.Insert, customers));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        /// <summary>
        /// 删除客户
        /// </summary>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该客户是否存在
                CoCustomers customers = context.CoCustomers.FirstOrDefault(obj => obj.ID == id);
                if (customers == null)
                    throw new FaultException(string.Format("客户不存在！"));
                context.CoCustomers.DeleteObject(customers); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoCustomersAdapter02", Define.Delete, customers));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改客户
        /// </summary>
        public static void Update(CoCustomers customers)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该客户是否存在
                CoCustomers _customers = context.CoCustomers.FirstOrDefault(obj => obj.ID == customers.ID);
                if (_customers == null)
                    throw new FaultException(string.Format("该客户[{0}]不存在！", customers.Name));
                EntityObjectHelper.Copyto(customers, ref _customers); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoCustomersAdapter03", Define.Update, _customers));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
