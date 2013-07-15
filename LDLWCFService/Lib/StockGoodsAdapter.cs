using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class StockGoodsAdapter
    {
        /// <summary>
        /// 获取库存记录
        /// </summary>
        public static List<StockGoods> GetStockGoodsBySite(string siteCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            if (string.IsNullOrEmpty(siteCode))
                return context.StockGoods.ToList();
            else
                return context.StockGoods.Where(obj => obj.OwnerSite == siteCode).ToList();
        }

        /// <summary>
        /// 按站点获取登记记录
        /// </summary>
        public static List<StockGoodsRegister> GetStockGoodsRegisterBySite(string siteCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            if (string.IsNullOrEmpty(siteCode))
                return context.StockGoodsRegister.Where(obj => obj.Valid == true).ToList();
            else
                return context.StockGoodsRegister.Where(obj => obj.OwnerSite == siteCode && obj.Valid == true).ToList();
        }

        /// <summary>
        /// 入库登记
        /// </summary>
        public static void InsertStockGoodsRegister(StockGoodsRegister objRegister)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                StockGoods objGoods = context.StockGoods.FirstOrDefault(obj => obj.OwnerSite == objRegister.OwnerSite && obj.Goods == objRegister.Goods);
                bool isExists = objGoods != null;

                //报损报废和调拨的数量超过库存是报错
                if (objRegister.ActionType == "报损报废" || objRegister.ActionType == "调拨")
                {
                    if (!isExists || objRegister.Number > objGoods.Number)
                        throw new Exception(string.Format("{0}数量({1})超出库存数量({2})", objRegister.ActionType,
                            objRegister.Number, objGoods == null ? 0 : objGoods.Number));
                }

                if (!isExists)
                {
                    objGoods = new StockGoods();
                    objGoods.OwnerSite = objRegister.OwnerSite;
                    objGoods.Goods = objRegister.Goods;
                    objGoods.Price = objRegister.Price;
                    objGoods.Number = objRegister.Number;
                }
                else
                {
                    if (objRegister.Price.HasValue && objRegister.ActionType == "入库")
                        objGoods.Price = objRegister.Price.Value;
                    if (objRegister.ActionType == "入库")
                        objGoods.Number += objRegister.Number;
                    else //报损报废和调拨 扣掉总数
                        objGoods.Number -= objRegister.Number;
                }

                context.StockGoodsRegister.AddObject(objRegister);    //新增入库登记
                if (!isExists)
                    context.StockGoods.AddObject(objGoods);           //新增或更新库存记录
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockGoodsAdapter01", Define.Insert, objRegister));   //记录日志
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
        public static void DeleteStockGoodsRegister(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                StockGoodsRegister objRegister = context.StockGoodsRegister.FirstOrDefault(obj => obj.ID == id && obj.Valid == true);
                if (objRegister == null)
                    throw new Exception("该入库登记记录不存在");


                StockGoods objGoods = context.StockGoods.FirstOrDefault(obj => obj.OwnerSite == objRegister.OwnerSite && obj.Goods == objRegister.Goods);
                if (objGoods == null)
                    throw new Exception("库存记录不存在");
                if (objRegister.ActionType == "入库")
                {
                    if (objGoods.Number < objRegister.Number)
                        throw new Exception(string.Format("库存数量({0})低于入库登记的数量({1})", objGoods.Number, objRegister.Number));
                    objGoods.Number -= objRegister.Number;
                }
                else
                {
                    objGoods.Number += objRegister.Number;
                }
                //设置入库登记记录无效
                objRegister.Valid = false;

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockGoodsAdapter02", Define.Delete, objRegister));   //记录日志
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
        public static List<StockGoodsProvide> GetStockGoodsProvideBySite(string siteCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            if (string.IsNullOrEmpty(siteCode))
                return context.StockGoodsProvide.Where(obj => obj.Valid == true).ToList();
            else
                return context.StockGoodsProvide.Where(obj => obj.SrcSite == siteCode && obj.Valid == true).ToList();
        }

        /// <summary>
        /// 物料发放
        /// </summary>
        public static void InsertStockGoodsProvide(StockGoodsProvide objProvide)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                StockGoods objGoods = context.StockGoods.FirstOrDefault(obj => obj.OwnerSite == objProvide.SrcSite && obj.Goods == objProvide.Goods);
                if (objGoods == null)
                    throw new Exception("库存记录不存在");
                if (objGoods.Number < objProvide.Number)
                    throw new Exception(string.Format("库存数量({0})不足够", objGoods.Number));
                objGoods.Number -= objProvide.Number;   //更新库存数量

                context.StockGoodsProvide.AddObject(objProvide);    //新增物料发放记录
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockGoodsAdapter03", Define.Insert, objProvide));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 物料发放删除
        /// </summary>
        public static void DeleteStockGoodsProvide(int id)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                StockGoodsProvide objProvide = context.StockGoodsProvide.FirstOrDefault(obj => obj.ID == id && obj.Valid == true);
                if (objProvide == null)
                    throw new Exception("物料发放记录不存在");
                StockGoods objGoods = context.StockGoods.FirstOrDefault(obj => obj.OwnerSite == objProvide.SrcSite && obj.Goods == objProvide.Goods);
                if (objGoods == null)
                    throw new Exception("库存记录不存在");
                //更新库存总量
                objGoods.Number += objProvide.Number;
                //设置物料发放记录无效
                objProvide.Valid = false;

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("StockGoodsAdapter04", Define.Delete, objProvide));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
