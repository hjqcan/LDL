using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using LDLWCFService.EF;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoCarAdapter
    {
        /// <summary>
        /// 获取车辆列表
        /// </summary>
        public static List<CoCar> GetCarList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoCar.ToList();
        }

        /// <summary>
        /// 新增车辆
        /// </summary>
        public static void Insert(CoCar car)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该车辆是否存在
                if (context.CoCar.Any(obj => obj.Code == car.Code && car.Valid == true))
                    throw new FaultException(string.Format("车辆编码[{0}]已存在！", car.Code));
                context.CoCar.AddObject(car);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoCarAdapter01", Define.Insert, car));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        /// <summary>
        /// 删除车辆
        /// </summary>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该车辆是否存在
                CoCar car = context.CoCar.FirstOrDefault(obj => obj.ID == id);
                if (car == null)
                    throw new FaultException(string.Format("车辆不存在！"));
                context.CoCar.DeleteObject(car); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoCarAdapter02", Define.Delete, car));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改车辆
        /// </summary>
        public static void Update(CoCar car)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该车辆是否存在
                CoCar _car = context.CoCar.FirstOrDefault(obj => obj.ID == car.ID);
                if (_car == null)
                    throw new FaultException(string.Format("该车辆[{0}]不存在！", car.LicenseNumber));
                EntityObjectHelper.Copyto(car, ref _car); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoCarAdapter03", Define.Update, _car));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
