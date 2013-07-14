using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LDL.Client.LDLService;
using DevExpress.XtraBars;

namespace LDL.Client.Common
{
    public class ToolbarHelper
    {
        public static void InitToolbar(Control form)
        {
            FrmMain._barManager.Form = form;
            FrmMain._barManager.Bars[0].Visible = true;

            SysRoleFunction userFunction = (SysRoleFunction)form.Tag;
            SysFunction func = Identity.CurrentFunction.Find(obj => obj.Code == userFunction.FunctionCode);
            bool isExistsFunc = func != null && userFunction != null;

            FrmMain._barbtnQuery.Visibility = isExistsFunc && func.QueryFlag.HasValue && func.QueryFlag.Value == true 
                && userFunction.QueryFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnInsert.Visibility = isExistsFunc && func.InsertFlag.HasValue && func.InsertFlag.Value == true
                && userFunction.InsertFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnUpdate.Visibility = isExistsFunc && func.UpdateFlag.HasValue && func.UpdateFlag.Value == true
                && userFunction.UpdateFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnDelete.Visibility = isExistsFunc && func.DeleteFlag.HasValue && func.DeleteFlag.Value == true
                && userFunction.DeleteFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnSave.Visibility = isExistsFunc && func.SaveFlag.HasValue && func.SaveFlag.Value == true
                && userFunction.SaveFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnPrint.Visibility = isExistsFunc && func.PrintFlag.HasValue && func.PrintFlag.Value == true
                && userFunction.PrintFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnImport.Visibility = isExistsFunc && func.ImportFlag.HasValue && func.ImportFlag.Value == true
                && userFunction.ImportFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
            FrmMain._barbtnExport.Visibility = isExistsFunc && func.ExportFlag.HasValue && func.ExportFlag.Value == true
                && userFunction.ExportFlag ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
    }
}
