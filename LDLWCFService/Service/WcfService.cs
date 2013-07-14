using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using LDLWCFService.Lib;

namespace LDLWCFService.Service
{
    public partial class WcfService : IWcfService
    {
        public string SayHello(string name)
        {
            return "hello:" + name;
        }

        #region sysversion

        public int GetVersion(string type)
        {
            return SysVersionAdapter.GetVersion(type);
        }

        #endregion

        #region sysuser

        public SysUser Login(string macAddress, string ipAddress, string hostName)
        {
            return SysUserAdapter.Login(macAddress, ipAddress, hostName);
        }

        public SysUser GetUser(string userName)
        {
            return SysUserAdapter.GetUser(userName);
        }

        public List<SysUser> GetUserList()
        {
            return SysUserAdapter.GetUserList();
        }

        public void InsertUser(SysUser user)
        {
            SysUserAdapter.Insert(user);
        }

        public void UpdateUser(SysUser user)
        {
            SysUserAdapter.Update(user);
        }

        public void DeleteUser(int id)
        {
            SysUserAdapter.Delete(id);
        }

        public List<SysUserFunction> GetUserFunction(int userID)
        {
            return SysUserAdapter.GetUserFunction(userID);
        }

        public List<SysUserLoginLog> GetUserLoginLog(string userName, DateTime startTime, DateTime endTime)
        {
            return SysUserAdapter.GetUserLoginLog(userName, startTime, endTime);
        }

        #endregion

        #region sysfunction

        public List<SysFunction> GetFunctionList()
        {
            return SysFunctionAdapter.GetFunctionList();
        }

        public void InsertFunction(SysFunction function)
        {
            SysFunctionAdapter.Insert(function);
        }

        public void UpdateFunction(SysFunction function)
        {
            SysFunctionAdapter.Update(function);
        }

        public void DeleteFunction(string code)
        {
            SysFunctionAdapter.Delete(code);
        }

        public List<SysFunction> GetFunctionByRole(string roleCode)
        {
            return SysFunctionAdapter.GetFunctionByRole(roleCode);
        }
        #endregion

        #region sysparameter

        public List<SysParameterType> GetParameterTypeList()
        {
            return SysParameterAdapter.GetParameterTypeList();
        }

        public List<SysParameter> GetParameterListByType(string type)
        {
            return SysParameterAdapter.GetParameterListByType(type);
        }

        public void InsertParameter(SysParameter parameter)
        {
            SysParameterAdapter.Insert(parameter);
        }

        public void DeleteParameter(int id)
        {
            SysParameterAdapter.Delete(id);
        }

        public void UpdateParameter(SysParameter parameter)
        {
            SysParameterAdapter.Update(parameter);
        }

        #endregion

        #region sysrole

        public List<SysRole> GetRoleList()
        {
            return SysRoleAdapter.GetRoleList();
        }

        public void InsertRole(SysRole role)
        {
            SysRoleAdapter.Insert(role);
        }

        public void DeleteRole(string roleCode)
        {
            SysRoleAdapter.Delete(roleCode);
        }

        public void UpdateRole(SysRole role)
        {
            SysRoleAdapter.Update(role);
        }

        public List<SysRoleFunction> GetRoleFunctionList(string roleCode)
        {
            return SysRoleAdapter.GetRoleFunctionList(roleCode);
        }

        public void UpdateRoleFunction(string roleCode, List<SysRoleFunction> lstNewRoleFunction)
        {
            SysRoleAdapter.UpdateRoleFunction(roleCode, lstNewRoleFunction);
        }

        #endregion

        #region codepartment

        public List<CoDepartment> GetDepartmentList()
        {
            return CoDepartmentAdapter.GetDepartmentList();
        }

        public void InsertDepartment(CoDepartment dept)
        {
            CoDepartmentAdapter.Insert(dept);
        }

        public void DeleteDepartment(int id)
        {
            CoDepartmentAdapter.Delete(id);
        }

        public void UpdateDepartment(CoDepartment dept)
        {
            CoDepartmentAdapter.Update(dept);
        }

        #endregion

        #region codesite

        public List<CoSite> GetSiteList()
        {
            return CoSiteAdapter.GetSiteList();
        }

        public void InsertSite(CoSite site)
        {
            CoSiteAdapter.Insert(site);
        }

        public void DeleteSite(string id)
        {
            CoSiteAdapter.Delete(id);
        }

        public void UpdateSite(CoSite site)
        {
            CoSiteAdapter.Update(site);
        }

        #endregion

        #region CoDestination

        public List<CoDestination> GetDestinationList()
        {
            return CoDestinationAdapter.GetDestinationList();
        }

        public void InsertDestination(CoDestination destination)
        {
            CoDestinationAdapter.Insert(destination);
        }

        public void DeleteDestination(int id)
        {
            CoDestinationAdapter.Delete(id);
        }

        public void UpdateDestination(CoDestination destination)
        {
            CoDestinationAdapter.Update(destination);
        }

        #endregion

        #region CoEmployee

        public List<CoEmployee> GetEmployeeList()
        {
            return CoEmployeeAdapter.GetEmployeeList();
        }

        public CoEmployee GetEmployee(int id)
        {
            return CoEmployeeAdapter.GetEmployee(id);
        }

        public List<CoEmployee> GetEmployeeByDepartment(int deptID)
        {
            return CoEmployeeAdapter.GetEmployeeByDepartment(deptID);
        }

        public void InsertEmployee(CoEmployee employee)
        {
            CoEmployeeAdapter.Insert(employee);
        }

        public void InsertEmployeeWithUser(CoEmployee employee, SysUser user)
        {
            CoEmployeeAdapter.InsertWithUser(employee, user);
        }

        public void DeleteEmployee(CoEmployee employee, bool delUser)
        {
            CoEmployeeAdapter.Delete(employee, delUser);
        }

        public void UpdateEmployee(CoEmployee employee)
        {
            CoEmployeeAdapter.Update(employee);
        }

        #endregion

        #region CoCustomers

        public List<CoCustomers> GetCustomersList()
        {
            return CoCustomersAdapter.GetCustomersList();
        }

        public void InsertCustomers(CoCustomers customers)
        {
            CoCustomersAdapter.Insert(customers);
        }

        public void DeleteCustomers(int id)
        {
            CoCustomersAdapter.Delete(id);
        }

        public void UpdateCustomers(CoCustomers customers)
        {
            CoCustomersAdapter.Update(customers);
        }

        #endregion

        #region CoCar

        public List<CoCar> GetCarList()
        {
            return CoCarAdapter.GetCarList();
        }

        public void InsertCar(CoCar car)
        {
            CoCarAdapter.Insert(car);
        }

        public void DeleteCar(int id)
        {
            CoCarAdapter.Delete(id);
        }

        public void UpdateCar(CoCar car)
        {
            CoCarAdapter.Update(car);
        }

        #endregion

        #region CoDriver

        public List<CoDriver> GetDriverList()
        {
            return CoDriverAdapter.GetDriverList();
        }

        public void InsertDriver(CoDriver driver)
        {
            CoDriverAdapter.Insert(driver);
        }

        public void DeleteDriver(int id)
        {
            CoDriverAdapter.Delete(id);
        }

        public void UpdateDriver(CoDriver driver)
        {
            CoDriverAdapter.Update(driver);
        }

        #endregion

        #region StockGoods

        public List<StockGoods> GetStockGoodsBySite(string siteCode)
        {
            return StockGoodsAdapter.GetStockGoodsBySite(siteCode);
        }

        public List<StockGoodsRegister> GetStockGoodsRegisterBySite(string siteCode)
        {
            return StockGoodsAdapter.GetStockGoodsRegisterBySite(siteCode);
        }

        public void InsertStockGoodsRegister(StockGoodsRegister objRegister)
        {
            StockGoodsAdapter.InsertStockGoodsRegister(objRegister);
        }

        public void DeleteStockGoodsRegister(int id)
        {
            StockGoodsAdapter.DeleteStockGoodsRegister(id);
        }

        public List<StockGoodsProvide> GetStockGoodsProvideBySite(string siteCode)
        {
            return StockGoodsAdapter.GetStockGoodsProvideBySite(siteCode);
        }

        public void InsertStockGoodsProvide(StockGoodsProvide objProvide)
        {
            StockGoodsAdapter.InsertStockGoodsProvide(objProvide);
        }

        public void DeleteStockGoodsProvide(int id)
        {
            StockGoodsAdapter.DeleteStockGoodsProvide(id);
        }

        #endregion

        #region StockWaybill

        public List<StockWaybill> GetStockWaybillBySite(string siteCode)
        {
            return StockWaybillAdapter.GetStockWaybillBySite(siteCode);
        }

        public List<StockWaybillRegister> GetStockWaybillRegisterBySite(string siteCode)
        {
            return StockWaybillAdapter.GetStockWaybillRegisterBySite(siteCode);
        }

        public void InsertStockWaybillRegister(StockWaybillRegister objRegister)
        {
            StockWaybillAdapter.InsertStockWaybillRegister(objRegister);
        }

        public void DeleteStockWaybillRegister(int id)
        {
            StockWaybillAdapter.DeleteStockWaybillRegister(id);
        }

        public List<StockWaybillProvide> GetStockWaybillProvideBySite(string siteCode)
        {
            return StockWaybillAdapter.GetStockWaybillProvideBySite(siteCode);
        }

        public void InsertStockWaybillProvide(StockWaybillProvide objProvide)
        {
            StockWaybillAdapter.InsertStockWaybillProvide(objProvide);
        }

        public void DeleteStockWaybillProvide(int id)
        {
            StockWaybillAdapter.DeleteStockWaybillProvide(id);
        }

        #endregion

        #region QuoteMain

        public List<QuoteMain> GetQuoteMainList()
        {
            return QuoteMainAdapter.GetQuoteMainList();
        }

        public QuoteMain GetQuoteMain(string guid)
        {
            return QuoteMainAdapter.GetQuoteMain(guid);
        }

        public List<QuoteMainRelation> GetQuoteMainRelationByID(string guid)
        {
            return QuoteMainAdapter.GetQuoteMainRelationByID(guid);
        }

        public List<QuoteExpression> GetQuoteExpressionByID(string guid)
        {
            return QuoteMainAdapter.GetQuoteExpressionByID(guid);
        }

        public void InsertQuoteMain(QuoteMain quoteMain, List<QuoteMainRelation> quoteMainRelation, List<QuoteExpression> quoteExpression)
        {
            QuoteMainAdapter.InsertQuoteMain(quoteMain, quoteMainRelation, quoteExpression);
        }

        public void DeleteQuoteMain(string guid)
        {
            QuoteMainAdapter.DeleteQuoteMain(guid);
        }

        public void UpdateQuoteMain(QuoteMain quoteMain, List<QuoteMainRelation> quoteMainRelation, List<QuoteExpression> quoteExpression)
        {
            QuoteMainAdapter.UpdateQuoteMain(quoteMain, quoteMainRelation, quoteExpression);
        }

        public List<QuoteExpression> GetQuoteExpressionList()
        {
            return QuoteMainAdapter.GetQuoteExpressionList();
        }

        public List<QuoteMainRelation> GetQuoteMainRelationList()
        {
            return QuoteMainAdapter.GetQuoteMainRelationList();
        }
        #endregion

        #region WaybillInfoAdapter

        public void InsertWaybillInfo(WaybillInfo waybillInfo, List<WaybillGoods> lstWaybillGoods)
        {
            WaybillInfoAdapter.InsertWaybillInfo(waybillInfo, lstWaybillGoods);
        }

        public string GetFirstWaybillCodeBySite(string site)
        {
            return WaybillInfoAdapter.GetFirstWaybillCodeBySite(site);
        }

        public List<WaybillInfo> GetWaybillInfo(DateTime startDate, DateTime endDate)
        {
            return WaybillInfoAdapter.GetWaybillInfo(startDate, endDate);
        }

        public List<WaybillGoods> GetWaybillGoods(string waybillCode)
        {
            return WaybillInfoAdapter.GetWaybillGoods(waybillCode);
        }

        #endregion 
    

        
    }
}
