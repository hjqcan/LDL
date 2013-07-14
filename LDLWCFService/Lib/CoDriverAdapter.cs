using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using LDLWCFService.EF;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoDriverAdapter
    {
        /// <summary>
        /// 获取司机列表
        /// </summary>
        public static List<CoDriver> GetDriverList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoDriver.ToList();
        }

        /// <summary>
        /// 新增司机
        /// </summary>
        public static void Insert(CoDriver driver)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该司机是否存在
                if (context.CoDriver.Any(obj => obj.Code == driver.Code && obj.Valid == true) )
                    throw new FaultException(string.Format("司机编码[{0}]已存在！", driver.Code));
                context.CoDriver.AddObject(driver);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDriverAdapter01", Define.Insert, driver));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        /// <summary>
        /// 删除司机
        /// </summary>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该司机是否存在
                CoDriver driver = context.CoDriver.FirstOrDefault(obj => obj.ID == id);
                if (driver == null)
                    throw new FaultException(string.Format("司机不存在！"));
                context.CoDriver.DeleteObject(driver); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDriverAdapter02", Define.Delete, driver));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改司机
        /// </summary>
        public static void Update(CoDriver driver)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该司机是否存在
                CoDriver _driver = context.CoDriver.FirstOrDefault(obj => obj.ID == driver.ID);
                if (_driver == null)
                    throw new FaultException(string.Format("该司机[{0}]不存在！", driver.Name));
                EntityObjectHelper.Copyto(driver, ref _driver); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDriverAdapter03", Define.Update, _driver));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
