using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.LDLService;
using LDL.Client.Common;
using LDL.Utility;

namespace LDL.Client.UserControls.Sys
{
    public partial class UCUserLoginLog : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<SysUserLoginLog> dataSource;

        #endregion

        public UCUserLoginLog()
        {
            InitializeComponent();
            InitControls();
        }

        #region 事件

        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (validationNotBlank.Validate() && validationProvider.Validate())
                    BindList();
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("查询失败", ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void gvData_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == "colValidation")
            {
                SysUserLoginLog log = (SysUserLoginLog)gvData.GetRow(e.RowHandle);
                e.DisplayText = SecurityHelper.MD5(log.MacAddress + "|" + log.HostName);
            }
        }
        #endregion

        #region 方法

        void InitControls()
        {
            dateEditStartDate.DateTime = DateTime.Today.AddDays(-7);
            dateEditEndDate.DateTime = DateTime.Today;
        }

        void BindList()
        {
            dataSource = WcfServiceHelper.Client.GetUserLoginLog(txtUserName.Text.Trim(), dateEditStartDate.DateTime, dateEditEndDate.DateTime.AddDays(1)).ToList();
            gridData.DataSource = dataSource;
        }

        #endregion

        #region 初始化工具栏，用继承类界面设计报错...

        /// <summary>
        /// 初始化工具栏，用继承类界面设计报错...
        /// </summary>
        public void InitToolbar()
        {
            ToolbarHelper.InitToolbar(this);
            ControlsHelper.AddEvent(FrmMain._barbtnQuery, _barbtnQuery_ItemClick);
        }

        #endregion

        

        
    }
}
