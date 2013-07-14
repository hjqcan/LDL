using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Management;
using System.Net.Sockets;

namespace LDL.Utility
{
    public class NetHelper
    {
        public static string GetHostName()
        {
            try
            {
                return Dns.GetHostName();
            }
            catch
            {
                return "unknow";
            }
        }

        public static string GetIPAddress()
        {
            try
            {
                IPAddress[] arrIPAddresses = Dns.GetHostAddresses ( Dns.GetHostName ( ) );
                foreach (IPAddress ip in arrIPAddresses)
                {
                    if (ip.AddressFamily.Equals(AddressFamily.InterNetwork))
                    {
                        return ip.ToString();
                    }
                }
                return "unknow";
            }
            catch
            {
                return "unknow";
            }
        }

        public static string GetMacAddress()
        {
            try
            {
                ManagementClass mc;
                mc = new ManagementClass("Win32_NetworkAdapterConfiguration"); ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if (mo["IPEnabled"].ToString() == "True")
                        return mo["MacAddress"].ToString();
                }
            }
            catch
            {
                return "unknow";
            }
            return "unknow";
        }
    }
}
