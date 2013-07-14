using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDLWCFService.EF;

namespace LDLWCFService.Lib
{
    public class SysVersionAdapter
    {
        public static int GetVersion(string type)
        {
            LDLLogisticsEntities context = new LDLLogisticsEntities();
            SysVersion version = context.SysVersion.FirstOrDefault(obj => obj.Type.ToLower().Trim() == type.ToLower().Trim());
            if (version == null)
                return -1;
            else
                return version.Version;
        }
    }
}
