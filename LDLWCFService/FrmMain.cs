using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using LDLWCFService.Service;
using LDLWCFService.EF;
using LDLWCFService;
using LDLWCFService.Lib;

namespace LocalService
{
    public partial class FrmMain : Form
    {
        ServiceHost host;
        public FrmMain()
        {
            InitializeComponent();

            Type serviceType = typeof(WcfService);
            host = new ServiceHost(serviceType);
            host.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SysUserAdapter.GetUser("123");
                MessageBox.Show("连接通过！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "连接失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
