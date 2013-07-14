using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDL.Client.LDLService;
using LDL.Utility;

namespace LDL.Client.Common
{
    public class CommonHelper
    {
        /// <summary>
        /// 获取该站点相关站，从子到父
        /// </summary>
        public static List<CoSite> GetSiteRelation(string id)
        {
            List<CoSite> newObjs = new List<CoSite>();
            List<CoSite> lstObj = FrequentlyUsedData.GetSiteList(false);

            CoSite site = lstObj.FirstOrDefault(obj=>obj.ID == id);
            while(site != null)
            {
                newObjs.Add(site);
                site = lstObj.FirstOrDefault(obj => obj.ID == site.ParentID);
            }

            return newObjs;
        }

        /// <summary>
        /// 报价计算
        /// </summary>
        public static decimal ComputeQuoteByExpression(decimal w, List<QuoteExpression> expressions)
        {
            int sortID = -1;
            decimal money = -1;

            foreach (QuoteExpression exp in expressions)
            {
                sortID = exp.SortID;
                object objCon = ComplierHelper.ComplierCode(exp.Condition.Replace("w", w.ToString()));
                object objResult = ComplierHelper.ComplierCode(exp.Expression.Replace("w", w.ToString()));
                if (objCon.GetType() != typeof(bool))
                    throw new Exception("条件公式不正确");
                decimal result;
                if (!decimal.TryParse(objResult.ToString(), out result))
                    throw new Exception("计算公式不正确");
                if ((bool)objCon && money == -1)
                    money = result;
            }
            return money == -1 ? 0 : money;
        }
    }
}
