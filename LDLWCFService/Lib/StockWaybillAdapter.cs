using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class StockWaybillAdapter
    {
        //State 0：已报损报废 1：已使用 2：未使用 3：审核中

        /// <summary>
        /// 获取库存记录 
        /// </summary>
        public static List<StockWaybill> GetStockWaybillBySite(string siteCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            if (string.IsNullOrEmpty(siteCode))
                return context.StockWaybill.Where(obj => obj.Type == "库存" && obj.State == "2").ToList();
            else
                return context.StockWaybill.Where(obj => obj.OwnerSite == siteCode && obj.Type == "库存" && obj.State == "2").ToList();
        }

        /// <summary>
        /// 按站点获取登记记录
        /// </summary>
        public static List<StockWaybillRegister> GetStockWaybillRegisterBySite(string siteCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            if (string.IsNullOrEmpty(siteCode))
                return context.StockWaybillRegister.Where(obj => obj.Valid == true).ToList();
            else
                return context.StockWaybillRegister.Where(obj => obj.OwnerSite == siteCode && obj.Valid == true).ToList();
        }

        /// <summary>
        /// 入库登记
        /// </summary>
        public static void InsertStockWaybillRegister(StockWaybillRegister objRegister)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //StockWaybill State 0：已报损报废 1：已使用 2：未使用 3：审核中
                long startCode = long.Parse(objRegister.StartCode);
                long endCode = long.Parse(objRegister.EndCode);
                for (long i = startCode; i <= endCode; i++)
                {
                    string currentCode = i.ToString();
                    StockWaybill objWaybill = context.StockWaybill.FirstOrDefault(obj => obj.Code == currentCode);
                    if (objWaybill != null)
                        throw new Exception(string.Format("运单号[{0}]已存在", currentCode));
                    objWaybill = new StockWaybill();
                    objWaybill.OwnerSite = objRegister.OwnerSite;
                    objWaybill.Code = currentCode;
                    objWaybill.State = "2";
                    objWaybill.Type = "库存";
                    objWaybill.Price = objRegister.Price;
                    context.StockWaybill.AddObject(objWaybill);
                }

                context.StockWaybillRegister.AddObject(objRegister);    //新增入库登记
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockWaybillAdapter01", Define.Insert, objRegister));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除入库登记
        /// </summary>
        public static void DeleteStockWaybillRegister(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                StockWaybillRegister objRegister = context.StockWaybillRegister.FirstOrDefault(obj => obj.ID == id && obj.Valid == true);
                if (objRegister == null)
                    throw new Exception("该入库登记记录不存在");
                //StockWaybill State 0：已报损报废 1：已使用 2：未使用 3：审核中
                long startCode = long.Parse(objRegister.StartCode);
                long endCode = long.Parse(objRegister.EndCode);
                for (long i = startCode; i <= endCode; i++)
                {
                    string currentCode = i.ToString();
                    StockWaybill objWaybill = context.StockWaybill.FirstOrDefault(obj => obj.Code == currentCode);
                    if (objWaybill == null)
                        throw new Exception(string.Format("运单号[{0}]不存在", currentCode));
                    else if (objWaybill.Type == "发放")
                        throw new Exception(string.Format("运单号[{0}]已发放", currentCode));
                    else if (objWaybill.OwnerSite != objWaybill.OwnerSite)
                        throw new Exception(string.Format("运单号[{0}]不属于该站点", currentCode));
                    context.StockWaybill.DeleteObject(objWaybill);
                }

                //设置入库登记记录无效
                objRegister.Valid = false;

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockWaybillAdapter02", Define.Delete, objRegister));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 按站点获取发放记录
        /// </summary>
        public static List<StockWaybillProvide> GetStockWaybillProvideBySite(string siteCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            if (string.IsNullOrEmpty(siteCode))
                return context.StockWaybillProvide.Where(obj => obj.Valid == true).ToList();
            else
                return context.StockWaybillProvide.Where(obj => obj.SrcSite == siteCode && obj.Valid == true).ToList();
        }

        /// <summary>
        /// 运单发放
        /// </summary>
        public static void InsertStockWaybillProvide(StockWaybillProvide objProvide)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //StockWaybill State 0：已报损报废 1：已使用 2：未使用 3：审核中
                long startCode = long.Parse(objProvide.StartCode);
                long endCode = long.Parse(objProvide.EndCode);
                for (long i = startCode; i <= endCode; i++)
                {
                    string currentCode = i.ToString();
                    StockWaybill objWaybill = context.StockWaybill.FirstOrDefault(obj => obj.OwnerSite == objProvide.SrcSite && obj.Code == currentCode);
                    if (objWaybill == null)
                        throw new Exception(string.Format("运单号[{0}]不存在", currentCode));
                    if (objWaybill.Type == "发放")
                        throw new Exception(string.Format("运单号[{0}]已发放", currentCode));
                    objWaybill.OwnerSite = objProvide.DestSite;
                    objWaybill.Type = "发放";
                    objWaybill.State = "2"; //以后要审核,先审核
                    objWaybill.Price = objProvide.Price;
                }

                context.StockWaybillProvide.AddObject(objProvide);    //新增物料发放记录
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockWaybillAdapter03", Define.Insert, objProvide));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 运单发放删除
        /// </summary>
        public static void DeleteStockWaybillProvide(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                StockWaybillProvide objProvide = context.StockWaybillProvide.FirstOrDefault(obj => obj.ID == id && obj.Valid == true);
                if (objProvide == null)
                    throw new Exception("运单发放记录不存在");
                //StockWaybill State 0：已报损报废 1：已使用 2：未使用 3：审核中
                long startCode = long.Parse(objProvide.StartCode);
                long endCode = long.Parse(objProvide.EndCode);
                for (long i = startCode; i <= endCode; i++)
                {
                    string currentCode = i.ToString();
                    StockWaybill objWaybill = context.StockWaybill.FirstOrDefault(obj => obj.OwnerSite == objProvide.DestSite && obj.Code == currentCode);
                    if (objWaybill == null)
                        throw new Exception(string.Format("运单号[{0}]不存在", currentCode));
                    objWaybill.OwnerSite = objProvide.SrcSite;
                    objWaybill.Type = "库存";
                    objWaybill.State = "2";
                }

                //设置物料发放记录无效
                objProvide.Valid = false;
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockWaybillAdapter04", Define.Delete, objProvide));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
