using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class SysParameterAdapter
    {
        /// <summary>
        /// 获取参数类型表
        /// </summary>
        public static List<SysParameterType> GetParameterTypeList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysParameterType.ToList();
        }

        /// <summary>
        /// 按类型获取参数列表
        /// </summary>
        public static List<SysParameter> GetParameterListByType(string type)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysParameter.Where(obj => obj.Type == type).ToList();
        }

        /// <summary>
        /// 新增参数
        /// </summary>
        public static void Insert(SysParameter parameter)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                if (context.SysParameter.Any(obj => obj.Type == parameter.Type && obj.Code == parameter.Code && obj.Valid == true))
                    throw new FaultException(string.Format("编号[{0}]已存在！", parameter.Code));
                context.SysParameter.AddObject(parameter);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysParameterAdapter01", Define.Insert, parameter));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除参数
        /// </summary>
        /// <param name="userName"></param>
        public static void Delete(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                SysParameter parameter = context.SysParameter.FirstOrDefault(obj => obj.ID == id);
                if (parameter == null)
                    throw new FaultException(string.Format("编号不存在！"));
                context.SysParameter.DeleteObject(parameter); //删除
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysParameterAdapter02", Define.Delete, parameter));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改参数
        /// </summary>
        public static void Update(SysParameter parameter)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该用户是否存在
                SysParameter _parameter = context.SysParameter.FirstOrDefault(obj => obj.ID == parameter.ID);
                if (_parameter == null)
                    throw new FaultException(string.Format("参数不存在！"));
                EntityObjectHelper.Copyto(parameter, ref _parameter); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysParameterAdapter03", Define.Update, _parameter));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
