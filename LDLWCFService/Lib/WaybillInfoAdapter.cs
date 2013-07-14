using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class WaybillInfoAdapter
    {
        /// <summary>
        /// 新增
        /// </summary>
        public static void InsertWaybillInfo(WaybillInfo waybillInfo, List<WaybillGoods> lstWaybillGoods)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找运单号是否可用
                StockWaybill waybill = context.StockWaybill.FirstOrDefault(obj => obj.OwnerSite == waybillInfo.ConsignorSite && obj.Code == waybillInfo.Code && obj.Type == "发放");
                if (waybill == null || waybill.State != "2")
                    throw new FaultException(string.Format("运单号[{0}]{1}！", waybillInfo.Code, waybill != null && waybill.State == "1" ? "已使用" : "未使用"));
                //运单号设为已使用
                waybill.State = "1";
                //保存
                context.WaybillInfo.AddObject(waybillInfo);
                foreach (WaybillGoods goods in lstWaybillGoods)
                    context.WaybillGoods.AddObject(goods);
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("WaybillInfoAdapter01", Define.Insert, waybillInfo));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 获取号码最低的可用运单编号
        /// </summary>
        public static string GetFirstWaybillCodeBySite(string siteID)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            //获取最后一个运单
            StockWaybill lastStockWaybill = context.StockWaybill.OrderByDescending(obj => obj.Code).FirstOrDefault(obj => obj.OwnerSite == siteID && obj.State == "1" && obj.Type == "发放");
            string lastCode = lastStockWaybill == null ? "0" : lastStockWaybill.Code;
            //获取最新的一个可用的运单编号
            StockWaybill newStockWaybill = context.StockWaybill.OrderBy(obj => obj.Code).FirstOrDefault(obj => obj.OwnerSite == siteID && obj.Code.CompareTo(lastCode) > 0 && obj.State == "2" && obj.Type == "发放");
            if (newStockWaybill == null)
                return null;
            else
                return newStockWaybill.Code;
        }

        /// <summary>
        /// 获取运单信息
        /// </summary>
        public static List<WaybillInfo> GetWaybillInfo(DateTime startDate, DateTime endDate)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.WaybillInfo.Where(obj => obj.CreateDate >= startDate && obj.CreateDate <= endDate).ToList();
        }

        /// <summary>
        /// 获取运单货物信息
        /// </summary>
        public static List<WaybillGoods> GetWaybillGoods(string waybillCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.WaybillGoods.Where(obj => obj.Valid == true).ToList();
        }
    }
}
