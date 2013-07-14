using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;
using System.ServiceModel;
using LDLWCFService.Common;

namespace LDLWCFService.Lib
{
    public class SysRoleAdapter
    {
        /// <summary>
        /// 获取角色列表
        /// </summary>
        public static List<SysRole> GetRoleList()
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysRole.ToList();
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        public static void Insert(SysRole role)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该角色是否存在
                if (context.SysRole.FirstOrDefault(obj => obj.RoleCode.ToLower().Trim() == role.RoleCode.ToLower().Trim()) != null)
                    throw new FaultException(string.Format("角色编码[{0}]已存在！", role.RoleCode));
                context.SysRole.AddObject(role);    //新增
                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysRoleAdapter01", Define.Insert, role));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        public static void Delete(string roleCode)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该角色是否存在
                SysRole role = context.SysRole.FirstOrDefault(obj => obj.RoleCode.ToLower().Trim() == roleCode.ToLower().Trim());
                if (role == null)
                    throw new FaultException(string.Format("角色编码[{0}]不存在！", roleCode));
                IQueryable<SysRoleFunction> delRoleFunctionList = context.SysRoleFunction.Where(obj => obj.RoleCode.ToLower().Trim() == roleCode.ToLower().Trim());
                foreach (SysRoleFunction roleFuction in delRoleFunctionList)
                    context.SysRoleFunction.DeleteObject(roleFuction);
                context.SysRole.DeleteObject(role); //删除

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysRoleAdapter02", Define.Delete, role));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        public static void Update(SysRole role)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                //查找该角色是否存在
                SysRole _role = context.SysRole.FirstOrDefault(obj => obj.RoleCode.ToLower().Trim() == role.RoleCode.ToLower().Trim());
                if (_role == null)
                    throw new FaultException(string.Format("该角色[{0}]不存在！", role.RoleName));
                EntityObjectHelper.Copyto(role, ref _role); //利用反射动态赋值

                context.SysOperationLog.AddObject(SysOperationLogAdapter.GetOperationtLog("SysRoleAdapter03", Define.Update, _role));   //记录日志
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        /// <summary>
        /// 获取角色菜单列表
        /// </summary>
        public static List<SysRoleFunction> GetRoleFunctionList(string roleCode)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            return context.SysRoleFunction.Where(obj => obj.RoleCode.ToLower().Trim() == roleCode.ToLower().Trim()).ToList();
        }

        /// <summary>
        /// 更新角色菜单
        /// </summary>
        public static void UpdateRoleFunction(string roleCode, List<SysRoleFunction> lstNewRoleFunction)
        {
            try
            {
                LDLLogisticsEntities context = new LDLLogisticsEntities();
                IQueryable<SysRoleFunction> delRoleFunctionList = context.SysRoleFunction.Where(obj => obj.RoleCode.ToLower().Trim() == roleCode.ToLower().Trim());
                foreach (SysRoleFunction roleFuction in delRoleFunctionList)
                    context.SysRoleFunction.DeleteObject(roleFuction);
                foreach (SysRoleFunction roleFuction in lstNewRoleFunction)
                    context.SysRoleFunction.AddObject(roleFuction);
                context.SaveChanges();  //提交保存
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
