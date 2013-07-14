using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class CoSiteAdapter
    {
        /// <summary>
        /// 获取站点列表
        /// </summary>
        public static List<CoSite> GetSiteList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.CoSite.ToList();
        }

        /// <summary>
        /// 新增站点
        /// </summary>
        public static void Insert(CoSite site)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该站点是否存在
                if (context.CoSite.Any(obj => obj.Code == site.Code && obj.Valid == true))
                    throw new FaultException(string.Format("站点编码[{0}]已存在！", site.Code));
                //主键
                string maxID = site.ParentID + "00";
                if (context.CoSite.Count(obj => obj.ParentID == site.ParentID) > 0)
                    maxID = context.CoSite.Where(obj => obj.ParentID == site.ParentID).Max(obj => obj.ID);
                site.ID = (int.Parse(maxID) + 1).ToString();

                context.CoSite.AddObject(site);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoSiteAdapter01", Define.Insert, site));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除站点
        /// </summary>
        public static void Delete(string id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该站点是否存在
                CoSite site = context.CoSite.FirstOrDefault(obj => obj.ID == id);
                if (site == null)
                    throw new FaultException(string.Format("站点不存在！"));

                context.CoSite.DeleteObject(site);
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoSiteAdapter02", Define.Delete, site));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改站点
        /// </summary>
        public static void Update(CoSite site)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该站点是否存在
                CoSite _site = context.CoSite.FirstOrDefault(obj => obj.ID == site.ID);
                if (_site == null)
                    throw new FaultException(string.Format("该站点[{0}]不存在！", site.Name));
                if (_site.Code != site.Code && context.CoSite.Any(obj => obj.Code == site.Code && obj.Valid == true))
                    throw new FaultException(string.Format("站点编码[{0}]已存在！", site.Code));

                    EntityObjectHelper.Copyto(site, ref _site); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("CoSiteAdapter03", Define.Update, _site));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
