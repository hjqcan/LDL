using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.Common;
using LDL.Client.LDLService;

namespace LDL.Client.UserControls.Stock
{
    public partial class UCStockGoods : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<StockGoods> dataSource;
        List<CoSite> lstSite;
        Dictionary<string, object> query ;

        #endregion

        public UCStockGoods()
        {
            InitializeComponent();
        }

        private void StockGoods_Load(object sender, EventArgs e)
        {
            BindParameter();
            ControlsHelper.InitControlSite(btneditSite);
        }

        #region 事件


        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (query == null)
                    query = new Dictionary<string, object>();

                string codeSite = "";
                if (btneditSite.Text.Trim() != "" && btneditSite.Tag != null)
                    codeSite = (btneditSite.Tag as CoSite).ID;
                query[btneditSite.Name] = codeSite;

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

        #endregion

        #region 方法

        void BindList()
        {
            if (query == null)
                return;

            dataSource = WcfServiceHelper.Client.GetStockGoodsBySite(query[btneditSite.Name].ToString()).ToList();
            gridData.DataSource = dataSource;
            gvData.BestFitColumns();
        }

        void BindParameter()
        {
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["OwnerSite"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
           //物料品名
            (gvData.Columns["Goods"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = FrequentlyUsedData.GetParameterList("StockGoods", false);
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
