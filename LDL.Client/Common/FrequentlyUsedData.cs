using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDL.Client.LDLService;

namespace LDL.Client.Common
{

    public class FrequentlyUsedData
    {
        static Dictionary<string, object> dictData = new Dictionary<string, object>();

        /// <summary>
        /// 获取参数类型列表
        /// </summary>
        public static List<SysParameterType> GetParameterTypeList(bool isRefreshData)
        {
            string key = "ParameterType";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<SysParameterType> _lstParameterType = WcfServiceHelper.Client.GetParameterTypeList().
                    OrderBy(obj => obj.OrderID).ToList();
                dictData[key] = _lstParameterType;
            }

            return (dictData[key] as List<SysParameterType>).Clone();
        }

        /// <summary>
        /// 按部门获取员工
        /// </summary>
        public static List<CoEmployee> GetEmployeeByDepartment(AppendType appendType, int deptID, bool isRefreshData)
        {
            string key = "Employee_" + deptID;
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<CoEmployee> _lstObjects = WcfServiceHelper.Client.GetEmployeeByDepartment(deptID).ToList();
                dictData[key] = _lstObjects;
            }

            List<CoEmployee> lstObjects = new List<CoEmployee>((List<CoEmployee>)dictData[key]);
            if (appendType != AppendType.None)
            {
                CoEmployee employee = new CoEmployee();
                employee.Name = appendType == AppendType.All ? "全部" : "";
                lstObjects.Insert(0, employee);
            }
            return lstObjects.Clone();
        }

        /// <summary>
        /// 获取员工
        /// </summary>
        public static List<CoEmployee> GetEmployeeList(AppendType appendType, bool isRefreshData)
        {
            string key = "Employee";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<CoEmployee> _lstObjects = WcfServiceHelper.Client.GetEmployeeList().ToList();
                dictData[key] = _lstObjects;
            }

            List<CoEmployee> lstObjects = new List<CoEmployee>((List<CoEmployee>)dictData[key]);
            if (appendType != AppendType.None)
            {
                CoEmployee employee = new CoEmployee();
                employee.Name = appendType == AppendType.All ? "全部" : "";
                lstObjects.Insert(0, employee);
            }
            return lstObjects.Clone();
        }

        /// <summary>
        /// 获取部门列表
        /// </summary>
        public static List<CoDepartment> GetDepartmentList(bool isRefreshData)
        {
            string key = "Department";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<CoDepartment> _lstDepartment = WcfServiceHelper.Client.GetDepartmentList().
                    OrderBy(obj => obj.OrderID).ToList();
                dictData[key] = _lstDepartment;
            }

            return (dictData[key] as List<CoDepartment>);
        }

        /// <summary>
        /// 获取站点列表
        /// </summary>
        public static List<CoSite> GetSiteList(bool isRefreshData)
        {
            string key = "Site";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<CoSite> _lstSite = WcfServiceHelper.Client.GetSiteList().ToList();
                dictData[key] = _lstSite;
            }
            return (dictData[key] as List<CoSite>).Clone();
        }

        /// <summary>
        /// 获取目的地列表
        /// </summary>
        public static List<CoDestination> GetDestinationList(bool isRefreshData)
        {
            string key = "Destination";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<CoDestination> _lstDestination = WcfServiceHelper.Client.GetDestinationList().ToList();
                dictData[key] = _lstDestination;
            }
            return (dictData[key] as List<CoDestination>).Clone();
        }

        /// <summary>
        /// 获取客户列表
        /// </summary>
        public static List<CoCustomers> GetCustomersList(bool isRefreshData)
        {
            string key = "Customers";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<CoCustomers> _lstCustomers = WcfServiceHelper.Client.GetCustomersList().ToList();
                dictData[key] = _lstCustomers;
            }
            return (dictData[key] as List<CoCustomers>).Clone();
        }

        /// <summary>
        /// 获取参数列表
        /// </summary>
        public static List<SysParameter> GetParameterList(string type, bool isRefreshData)
        {
            return GetParameterList(type, isRefreshData, AppendType.None);
        }

        /// <summary>
        /// 获取参数列表
        /// </summary>
        public static List<SysParameter> GetParameterList(string type, bool isRefreshData, AppendType appendType)
        {
            if (!dictData.ContainsKey("para_" + type) || isRefreshData)
            {
                int version = WcfServiceHelper.Client.GetVersion(type);
                if (version != -1) //按版本加载
                {
                    EF.Version v = LocalStoreHelper.Context.Version.FirstOrDefault(obj => obj.Type.ToLower().Trim() == type.ToLower().Trim());

                    #region 保存到本地
                    if (v == null || v.Version1 != version)
                    {
                        //下载到本地
                        List<SysParameter> objs = WcfServiceHelper.Client.GetParameterListByType(type).ToList();
                        //删除本地的数据
                        EF.LocalStoreEntities context = LocalStoreHelper.Context;
                        IQueryable<EF.Parameter> paras = LocalStoreHelper.Context.Parameter.Where(obj => obj.Type.ToLower().Trim() == type.ToLower().Trim());
                        foreach (EF.Parameter p in paras)
                            context.Parameter.DeleteObject(p);
                        //加载到本地
                        foreach (SysParameter p in objs)
                        {
                            EF.Parameter newObj = new EF.Parameter();
                            newObj.Type = type;
                            newObj.Code = p.Code;
                            newObj.Name = p.DisplayName;
                            newObj.ParentCode = p.ParentCode;
                            newObj.OrderID = p.OrderID;
                            newObj.Valid = p.Valid;
                            context.Parameter.AddObject(newObj);
                        }
                        if (v != null)
                            context.Version.DeleteObject(v);
                        EF.Version newVersion = new EF.Version();
                        newVersion.Type = type;
                        newVersion.Version1 = version;
                        context.Version.AddObject(newVersion);
                        context.SaveChanges();
                    }
                    #endregion

                    #region 从本地加载
                    List<EF.Parameter> lstParameter = LocalStoreHelper.Context.Parameter.Where(obj => obj.Type.ToLower().Trim() == type.ToLower().Trim()).OrderBy(obj => obj.OrderID).ToList();
                    List<SysParameter> _lstParameterType = new List<SysParameter>();
                    foreach (EF.Parameter p in lstParameter)
                    {
                        SysParameter newObj = new SysParameter();
                        newObj.Type = p.Type;
                        newObj.Code = p.Code;
                        newObj.DisplayName = p.Name;
                        newObj.ParentCode = p.ParentCode;
                        newObj.OrderID = p.OrderID;
                        newObj.Valid = p.Valid;
                        _lstParameterType.Add(newObj);
                    }
                    dictData["para_" + type] = _lstParameterType;
                    #endregion
                }
                else //直接加载
                {
                    List<SysParameter> _lstParameterType = WcfServiceHelper.Client.GetParameterListByType(type).ToList().
                        OrderBy(obj => obj.OrderID).ToList();
                    dictData["para_" + type] = _lstParameterType;
                }
            }

            List<SysParameter> resultObj = ((List<SysParameter>)dictData["para_" + type]).Clone();
            if (appendType != AppendType.None)
            {
                SysParameter p = new SysParameter();
                p.Code = "";
                if (appendType == AppendType.Blank)
                    p.DisplayName = "";
                else if (appendType == AppendType.All)
                    p.DisplayName = "全部";
                p.Valid = true;
                resultObj.Insert(0, p);
            }



            return resultObj;
        }

        /// <summary>
        /// 获取报价单主表
        /// </summary>
        public static List<QuoteMain> GetQuoteMainList(bool isRefreshData)
        {
            {
                string key = "QuoteMain";
                if (!dictData.ContainsKey(key) || isRefreshData)
                {
                    List<QuoteMain> _lstQuoteMain = WcfServiceHelper.Client.GetQuoteMainList().ToList();
                    dictData[key] = _lstQuoteMain;
                }
                return (dictData[key] as List<QuoteMain>).Clone();
            }
        }

        /// <summary>
        /// 获取报价单表达式
        /// </summary>
        public static List<QuoteExpression> GetQuoteExpressionList(bool isRefreshData)
        {
            {
                string key = "QuoteExpression";
                if (!dictData.ContainsKey(key) || isRefreshData)
                {
                    List<QuoteExpression> _lstQuoteExpression = WcfServiceHelper.Client.GetQuoteExpressionList().ToList();
                    dictData[key] = _lstQuoteExpression;
                }
                return (dictData[key] as List<QuoteExpression>).Clone();
            }
        }

        /// <summary>
        /// 获取报价单关系表
        /// </summary>
        public static List<QuoteMainRelation> GetQuoteMainRelationList(bool isRefreshData)
        {
            string key = "QuoteMainRelation";
            if (!dictData.ContainsKey(key) || isRefreshData)
            {
                List<QuoteMainRelation> _lstQuoteMainRelation = WcfServiceHelper.Client.GetQuoteMainRelationList().ToList();
                dictData[key] = _lstQuoteMainRelation;
            }
            return (dictData[key] as List<QuoteMainRelation>).Clone();
        }
    }
}
