using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LDL.Client.LDLService;
using System.ServiceModel;

namespace LDL.Client.Common
{
    public class WcfServiceHelper
    {
        private static WcfServiceClient client;
        public static WcfServiceClient Client
        {
            get
            {
                if (client == null || client.State == CommunicationState.Faulted || 
                    client.State == CommunicationState.Closed || client.State == CommunicationState.Closing)
                {
                    if (Common.Identity.CurrentUser == null)
                        throw new Exception("请先获取用户信息！");

                    client = new WcfServiceClient();
                    client.ClientCredentials.UserName.UserName = Common.Identity.CurrentUser.UserName;
                    client.ClientCredentials.UserName.Password = Common.Identity.CurrentUser.Password;
                }

                return client;
            }
        }
    }
}
