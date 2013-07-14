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
    public partial class UCStockWaybill : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<_StockWaybill> dataSource;
        List<CoSite> lstSite;
        Dictionary<string, object> query;

        #endregion

        public UCStockWaybill()
        {
            InitializeComponent();
        }

        private void UCStockWaybill_Load(object sender, EventArgs e)
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

            dataSource = GetStockWaybillBySite(query[btneditSite.Name].ToString());

            gridData.DataSource = dataSource;
            gvData.BestFitColumns();
        }

        public static List<_StockWaybill> GetStockWaybillBySite(string siteCode)
        {
            List<StockWaybill> lstStockWaybill = WcfServiceHelper.Client.GetStockWaybillBySite(siteCode).OrderBy(obj => obj.Code).ToList();
            List<_StockWaybill> data = new List<_StockWaybill>();

            StockWaybill startObj = null;
            StockWaybill endObj = null;
            foreach (StockWaybill obj in lstStockWaybill)
            {
                //首次
                if (startObj == null)
                {
                    startObj = obj;
                }
                else
                {
                    //分段区间结束，开始计算
                    if (startObj.OwnerSite != obj.OwnerSite || startObj.Price != obj.Price ||
                       long.Parse(endObj.Code) + 1 != long.Parse(obj.Code)) //号码断开的
                    {
                        //把区间转成一条记录
                        data.Add(ConvertToNewObj(startObj, endObj));
                        //重新再来
                        startObj = obj;
                    }
                }

                endObj = obj;
            }
            //最后还要转一次
            if (startObj != null && endObj != null)
                data.Add(ConvertToNewObj(startObj, endObj));

            return data;
        }

        public static _StockWaybill ConvertToNewObj(StockWaybill startObj, StockWaybill endObj)
        {
            _StockWaybill newObj = new _StockWaybill();
            newObj.StartCode = startObj.Code;
            newObj.EndCode = endObj.Code;
            newObj.OwnerSite = startObj.OwnerSite;
            newObj.Price = startObj.Price;
            newObj.Number = long.Parse(endObj.Code) - long.Parse(startObj.Code) + 1;
            return newObj;
        }

        void BindParameter()
        {
            //站点
            lstSite = FrequentlyUsedData.GetSiteList(false).Where(obj => obj.Valid == true).ToList();
            (gvData.Columns["OwnerSite"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSite;
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

    public class _StockWaybill
    {
        public string StartCode { get; set; }
        public string EndCode { get; set; }
        public string OwnerSite { get; set; }
        public decimal? Price { get; set; }
        public decimal Number { get; set; }
    }
}
