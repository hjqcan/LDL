using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoDestinationAdapter
    {
        /// <summary>
        /// 获取目的地列表
        /// </summary>
        public static List<CoDestination> GetDestinationList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoDestination.ToList();
        }

        /// <summary>
        /// 新增目的地
        /// </summary>
        public static void Insert(CoDestination destination)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该目的地是否存在
                if (context.CoDestination.Any(obj => obj.Code == destination.Code && obj.Valid == true))
                    throw new FaultException(string.Format("目的地编码[{0}]已存在！", destination.Code));
                context.CoDestination.AddObject(destination);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDestinationAdapter01", Define.Insert, destination));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除目的地
        /// </summary>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该目的地是否存在
                CoDestination destination = context.CoDestination.FirstOrDefault(obj => obj.ID == id);
                if (destination == null)
                    throw new FaultException(string.Format("目的地不存在！"));
                context.CoDestination.DeleteObject(destination); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDestinationAdapter02", Define.Delete, destination));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改目的地
        /// </summary>
        public static void Update(CoDestination destination)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该目的地是否存在
                CoDestination _destination = context.CoDestination.FirstOrDefault(obj => obj.ID == destination.ID);
                if (_destination == null)
                    throw new FaultException(string.Format("该目的地不存在！"));
                EntityObjectHelper.Copyto(destination, ref _destination); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoDestinationAdapter03", Define.Update, _destination));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
