using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using LDLWCFService.EF;

namespace LDLWCFService.Service
{
    [ServiceContract]
    public partial interface IWcfService
    {
        [OperationContract]
        string SayHello(string name);

        #region sysversion

        [OperationContract]
        int GetVersion(string type);

        #endregion

        #region sysuser

        [OperationContract]
        SysUser Login(string macAddress, string ipAddress, string hostName);
        [OperationContract]
        SysUser GetUser(string userName);
        [OperationContract]
        List<SysUser> GetUserList();
        [OperationContract]
        void InsertUser(SysUser user);
        [OperationContract]
        void UpdateUser(SysUser user);
        [OperationContract]
        void DeleteUser(int id);
        [OperationContract]
        List<SysUserFunction> GetUserFunction(int userID);
        [OperationContract]
        List<SysUserLoginLog> GetUserLoginLog(string userName, DateTime startTime, DateTime endTime);

        #endregion

        #region sysfunction

        [OperationContract]
        List<SysFunction> GetFunctionList();
        [OperationContract]
        void InsertFunction(SysFunction function);
        [OperationContract]
        void UpdateFunction(SysFunction function);
        [OperationContract]
        void DeleteFunction(string code);
        [OperationContract]
        List<SysFunction> GetFunctionByRole(string roleCode);

        #endregion

        #region sysparameter

        [OperationContract]
        List<SysParameterType> GetParameterTypeList();
        [OperationContract]
        List<SysParameter> GetParameterListByType(string type);
        [OperationContract]
        void InsertParameter(SysParameter parameter);
        [OperationContract]
        void DeleteParameter(int id);
        [OperationContract]
        void UpdateParameter(SysParameter parameter);

        #endregion

        #region sysrole

        [OperationContract]
        List<SysRole> GetRoleList();
        [OperationContract]
        void InsertRole(SysRole role);
        [OperationContract]
        void DeleteRole(string roleCode);
        [OperationContract]
        void UpdateRole(SysRole role);
        [OperationContract]
        List<SysRoleFunction> GetRoleFunctionList(string roleCode);
        [OperationContract]
        void UpdateRoleFunction(string roleCode, List<SysRoleFunction> lstNewRoleFunction);

        #endregion

        #region codepartment

        [OperationContract]
        List<CoDepartment> GetDepartmentList();
        [OperationContract]
        void InsertDepartment(CoDepartment dept);
        [OperationContract]
        void DeleteDepartment(int id);
        [OperationContract]
        void UpdateDepartment(CoDepartment dept);

        #endregion

        #region codesite

        [OperationContract]
        List<CoSite> GetSiteList();
        [OperationContract]
        void InsertSite(CoSite site);
        [OperationContract]
        void DeleteSite(string id);
        [OperationContract]
        void UpdateSite(CoSite site);

        #endregion

        #region CoDestination

        [OperationContract]
        List<CoDestination> GetDestinationList();
        [OperationContract]
        void InsertDestination(CoDestination destination);
        [OperationContract]
        void DeleteDestination(int id);
        [OperationContract]
        void UpdateDestination(CoDestination destination);

        #endregion

        #region CoEmployee

        [OperationContract]
        List<CoEmployee> GetEmployeeList();
        [OperationContract]
        CoEmployee GetEmployee(int id);
        [OperationContract]
        List<CoEmployee> GetEmployeeByDepartment(int deptID);
        [OperationContract]
        void InsertEmployee(CoEmployee employee);
        [OperationContract]
        void InsertEmployeeWithUser(CoEmployee employee, SysUser user);
        [OperationContract]
        void DeleteEmployee(CoEmployee employee, bool delUser);
        [OperationContract]
        void UpdateEmployee(CoEmployee employee);

        #endregion

        #region CoCustomers

        [OperationContract]
        List<CoCustomers> GetCustomersList();
        [OperationContract]
        void InsertCustomers(CoCustomers customers);
        [OperationContract]
        void DeleteCustomers(int id);
        [OperationContract]
        void UpdateCustomers(CoCustomers customers);

        #endregion

        #region CoCar

        [OperationContract]
        List<CoCar> GetCarList();
        [OperationContract]
        void InsertCar(CoCar car);
        [OperationContract]
        void DeleteCar(int id);
        [OperationContract]
        void UpdateCar(CoCar car);

        #endregion

        #region CoDriver

        [OperationContract]
        List<CoDriver> GetDriverList();
        [OperationContract]
        void InsertDriver(CoDriver driver);
        [OperationContract]
        void DeleteDriver(int id);
        [OperationContract]
        void UpdateDriver(CoDriver driver);

        #endregion

        #region StockGoods

        [OperationContract]
        List<StockGoods> GetStockGoodsBySite(string siteCode);
        [OperationContract]
        List<StockGoodsRegister> GetStockGoodsRegisterBySite(string siteCode);
        [OperationContract]
        void InsertStockGoodsRegister(StockGoodsRegister objRegister);
        [OperationContract]
        void DeleteStockGoodsRegister(int id);
        [OperationContract]
        List<StockGoodsProvide> GetStockGoodsProvideBySite(string siteCode);
        [OperationContract]
        void InsertStockGoodsProvide(StockGoodsProvide objProvide);
        [OperationContract]
        void DeleteStockGoodsProvide(int id);

        #endregion

        #region StockWaybill

        [OperationContract]
        List<StockWaybill> GetStockWaybillBySite(string siteCode);
        [OperationContract]
        List<StockWaybillRegister> GetStockWaybillRegisterBySite(string siteCode);
        [OperationContract]
        void InsertStockWaybillRegister(StockWaybillRegister objRegister);
        [OperationContract]
        void DeleteStockWaybillRegister(int id);
        [OperationContract]
        List<StockWaybillProvide> GetStockWaybillProvideBySite(string siteCode);
        [OperationContract]
        void InsertStockWaybillProvide(StockWaybillProvide objProvide);
        [OperationContract]
        void DeleteStockWaybillProvide(int id);

        #endregion

        #region QuoteMain
        [OperationContract]
        List<QuoteMain> GetQuoteMainList();
        [OperationContract]
        QuoteMain GetQuoteMain(string guid);
        [OperationContract]
        List<QuoteMainRelation> GetQuoteMainRelationByID(string guid);
        [OperationContract]
        List<QuoteExpression> GetQuoteExpressionByID(string guid);
        [OperationContract]
        void InsertQuoteMain(QuoteMain quoteMain, List<QuoteMainRelation> quoteMainRelation, List<QuoteExpression> quoteExpression);
        [OperationContract]
        void DeleteQuoteMain(string guid);
        [OperationContract]
        void UpdateQuoteMain(QuoteMain quoteMain, List<QuoteMainRelation> quoteMainRelation, List<QuoteExpression> quoteExpression);

        #endregion

        #region WaybillInfoAdapter

        [OperationContract]
        void InsertWaybillInfo(WaybillInfo waybillInfo, List<WaybillGoods> lstWaybillGoods);
        [OperationContract]
        string GetFirstWaybillCodeBySite(string site);
        [OperationContract]
        List<WaybillInfo> GetWaybillInfo(DateTime startDate, DateTime endDate);
        [OperationContract]
        List<WaybillGoods> GetWaybillGoods(string waybillCode);
        [OperationContract]
        List<QuoteExpression> GetQuoteExpressionList();
        [OperationContract]
        List<QuoteMainRelation> GetQuoteMainRelationList();
        #endregion 
    }
}
