using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using LDLWCFService.EF;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class QuoteMainAdapter
    {
        /// <summary>
        /// 获取报价列表
        /// </summary>
        public static List<QuoteMain> GetQuoteMainList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.QuoteMain.Where(obj => obj.Valid == true).ToList();
        }

        /// <summary>
        /// 获取报价
        /// </summary>
        public static QuoteMain GetQuoteMain(string guid)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.QuoteMain.FirstOrDefault(obj => obj.Guid == guid && obj.Valid == true);
        }

        /// <summary>
        /// 获取报价关系
        /// </summary>
        public static List<QuoteMainRelation> GetQuoteMainRelationByID(string guid)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.QuoteMainRelation.Where(obj => obj.SrcID == guid).ToList();
        }

        /// <summary>
        /// 获取报价关系列表
        /// </summary>
        public static List<QuoteMainRelation> GetQuoteMainRelationList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.QuoteMainRelation.ToList();
        }

        /// <summary>
        /// 获取报价公式
        /// </summary>
        public static List<QuoteExpression> GetQuoteExpressionByID(string guid)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.QuoteExpression.Where(obj => obj.SrcID == guid).ToList();
        }

        /// <summary>
        /// 获取报价列表
        /// </summary>
        public static List<QuoteExpression> GetQuoteExpressionList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.QuoteExpression.ToList();
        }

        /// <summary>
        /// 新增报价信息
        /// </summary>
        public static void InsertQuoteMain(QuoteMain quoteMain, List<QuoteMainRelation> quoteMainRelation, List<QuoteExpression> quoteExpression)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该ID是否存在，防止重复插入
                if (context.QuoteMain.FirstOrDefault(obj => obj.Guid.Trim().ToLower() == quoteMain.Guid.Trim().ToLower()) != null)
                    throw new FaultException(string.Format("报价已存在！"));
                //插入报价关系表
                foreach (QuoteMainRelation obj in quoteMainRelation)
                    context.QuoteMainRelation.AddObject(obj);
                //插入报价公式表
                foreach (QuoteExpression obj in quoteExpression)
                    context.QuoteExpression.AddObject(obj);
                context.QuoteMain.AddObject(quoteMain);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("QuoteMainAdapter01", Define.Insert, quoteMain));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除报价
        /// </summary>
        public static void DeleteQuoteMain(string guid)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该站点是否存在
                QuoteMain quoteMain = context.QuoteMain.FirstOrDefault(obj => obj.Guid == guid);
                if (quoteMain == null)
                    throw new FaultException(string.Format("报价不存在！"));
                quoteMain.Valid = false;
                //context.QuoteMain.DeleteObject(quoteMain); //删除
                //删除报价关系表
                //IQueryable<QuoteMainRelation> queryQuoteMainRelation = context.QuoteMainRelation.Where(obj => obj.SrcID == quoteMain.Guid);
                //foreach (QuoteMainRelation obj in queryQuoteMainRelation)
                //    context.QuoteMainRelation.DeleteObject(obj);
                //删除报价公式表
                //IQueryable<QuoteExpression> queryQuoteExpression = context.QuoteExpression.Where(obj => obj.SrcID == quoteMain.Guid);
                //foreach (QuoteExpression obj in queryQuoteExpression)
                //    context.QuoteExpression.DeleteObject(obj);
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("QuoteMainAdapter02", Define.Delete, quoteMain));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改报价信息
        /// </summary>
        public static void UpdateQuoteMain(QuoteMain quoteMain, List<QuoteMainRelation> quoteMainRelation, List<QuoteExpression> quoteExpression)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该报价是否存在
                QuoteMain _quoteMain = context.QuoteMain.FirstOrDefault(obj => obj.Guid == quoteMain.Guid);
                if (_quoteMain == null)
                    throw new FaultException(string.Format("报价[{0}]不存在！", quoteMain.Name));
                EntityObjectHelper.Copyto(quoteMain, ref _quoteMain); //利用反射动态赋值
                //清除报价关系表，插入新的关系表
                IQueryable<QuoteMainRelation> queryQuoteMainRelation = context.QuoteMainRelation.Where(obj => obj.SrcID == quoteMain.Guid);
                foreach (QuoteMainRelation obj in queryQuoteMainRelation)
                    context.QuoteMainRelation.DeleteObject(obj);
                foreach (QuoteMainRelation obj in quoteMainRelation)
                    context.QuoteMainRelation.AddObject(obj);
                //清除报价公式表，插入新的公式表
                IQueryable<QuoteExpression> queryQuoteExpression = context.QuoteExpression.Where(obj => obj.SrcID == quoteMain.Guid);
                foreach (QuoteExpression obj in queryQuoteExpression)
                    context.QuoteExpression.DeleteObject(obj);
                foreach (QuoteExpression obj in quoteExpression)
                    context.QuoteExpression.AddObject(obj);
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("QuoteMainAdapter03", Define.Update, _quoteMain));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


    }
}
