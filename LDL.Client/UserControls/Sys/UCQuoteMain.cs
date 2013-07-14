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

namespace LDL.Client.UserControls.Sys
{
    public partial class UCQuoteMain : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<QuoteMain> dataSource;
        List<QuoteMainRelation> lstRelation;

        #endregion

        public UCQuoteMain()
        {
            InitializeComponent();
        }

        private void UCQuoteMain_Load(object sender, EventArgs e)
        {

        }

        #region 事件


        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
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

        //新增
        void _barbtnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FrmQuoteMainEdit frm = new FrmQuoteMainEdit("新增", "");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindList();
                ControlsHelper.ShowAlertMessage(this.ParentForm, "新增", "新增成功");
            }
            this.Cursor = Cursors.Default;
        }

        //修改
        void _barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的报价");
            }
            else
            {
                QuoteMain quoteMain = (QuoteMain)gvData.GetRow(gvData.FocusedRowHandle);
                FrmQuoteMainEdit frm = new FrmQuoteMainEdit("修改", quoteMain.Guid);
                BindList();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindList();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "修改", "修改成功");
                }
            }
            this.Cursor = Cursors.Default;
        }

        //删除
        void _barbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvData.FocusedRowHandle < 0)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的员工");
            }
            else
            {
                QuoteMain quoteMain = (QuoteMain)gvData.GetRow(gvData.FocusedRowHandle);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除报价[{0}]吗？", quoteMain.Name)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        WcfServiceHelper.Client.DeleteQuoteMain(quoteMain.Guid);
                        BindList();
                        ControlsHelper.ShowAlertMessage(this.ParentForm, "删除", "删除成功");
                    }
                    catch (Exception ex)
                    {
                        ControlsHelper.ShowErrorMessage("删除失败", ex.Message);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void gvData_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            QuoteMain quoteMain = gvData.GetRow(e.RowHandle) as QuoteMain;
            List<string> lstName;
            if (e.Column.Name == "colSite")
            {
                lstName = new List<string>();
                List<CoSite> lstSite = FrequentlyUsedData.GetSiteList(false);
                List<QuoteMainRelation> lstObjs = lstRelation.FindAll(obj => obj.SrcID == quoteMain.Guid && obj.Type == "寄件站点");
                foreach (QuoteMainRelation r in lstObjs)
                {
                    CoSite site = lstSite.Find(obj => obj.ID.ToString() == r.Code);
                    if (site != null)
                        lstName.Add(site.Name);
                }
                e.DisplayText = string.Join(";", lstName);
            }
            else if (e.Column.Name == "colDestination")
            {
                lstName = new List<string>();
                List<CoDestination> lstDestination = FrequentlyUsedData.GetDestinationList(false);
                List<QuoteMainRelation> lstObjs = lstRelation.FindAll(obj => obj.SrcID == quoteMain.Guid && obj.Type == "派件区域");
                foreach (QuoteMainRelation r in lstObjs)
                {
                    CoDestination destination = lstDestination.Find(obj => obj.ID.ToString() == r.Code);
                    if (destination != null)
                        lstName.Add(destination.Name);
                }
                e.DisplayText = string.Join(";", lstName);
            }
            else if (e.Column.Name == "colCustomer")
            {
                lstName = new List<string>();
                List<CoCustomers> lstSite = FrequentlyUsedData.GetCustomersList(false);
                List<QuoteMainRelation> lstObjs = lstRelation.FindAll(obj => obj.SrcID == quoteMain.Guid && obj.Type == "报价客户");
                foreach (QuoteMainRelation r in lstObjs)
                {
                    CoCustomers customers = lstSite.Find(obj => obj.ID.ToString() == r.Code);
                    if (customers != null)
                        lstName.Add(customers.Name);
                }
                e.DisplayText = string.Join(";", lstName);
            }
        }


        #endregion

        #region 方法

        void BindList()
        {
            dataSource = WcfServiceHelper.Client.GetQuoteMainList().ToList();
            lstRelation = new List<QuoteMainRelation>();
            foreach (QuoteMain obj in dataSource)
                lstRelation.AddRange(WcfServiceHelper.Client.GetQuoteMainRelationByID(obj.Guid));

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
            ControlsHelper.AddEvent(FrmMain._barbtnInsert, _barbtnInsert_ItemClick);
            ControlsHelper.AddEvent(FrmMain._barbtnUpdate, _barbtnUpdate_ItemClick);
            ControlsHelper.AddEvent(FrmMain._barbtnDelete, _barbtnDelete_ItemClick);
        }

        #endregion

        
    }
}
