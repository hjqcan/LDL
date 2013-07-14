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
    public partial class UCSite : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<CoSite> dataSource;
        List<SysParameter> dataSourceCity;
        #endregion

        public UCSite()
        {
            InitializeComponent();
        }

        #region 事件

        private void UCSite_Load(object sender, EventArgs e)
        {
            BindParameter();
        }

        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                BindList();
                treeListData.ExpandAll();
                treeListData.BestFitColumns();
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
            if (treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击新增站点的上级站点");
            }
            else
            {
                string id = treeListData.FocusedNode["ID"].ToString();
                FrmSiteEdit frmSite = new FrmSiteEdit(DBOperateType.Insert, null, id);
                if (frmSite.ShowDialog() == DialogResult.OK)
                {
                    BindList();
                    treeListData.ExpandAll();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "新增", "新增成功");
                }
            }
            this.Cursor = Cursors.Default;
        }

        //修改
        void _barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的站点");
            }
            else
            {
                string id = treeListData.FocusedNode["ID"].ToString();
                CoSite site = dataSource.Find(obj=>obj.ID == id);
                FrmSiteEdit frmSite = new FrmSiteEdit(DBOperateType.Update, site, null);
                if (frmSite.ShowDialog() == DialogResult.OK)
                {
                    BindList();
                    treeListData.ExpandAll();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "修改", "修改成功");
                }
            }
        }

        //删除
        void _barbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的站点");
            }
            else if (treeListData.FocusedNode.ParentNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "顶级站点不可删除");
            }
            else
            {
                string id = treeListData.FocusedNode["ID"].ToString();
                CoSite site = dataSource.Find(obj => obj.ID == id);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除站点[{0}]吗？", site.Name)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        site.ModifyUser = Identity.CurrentUser.UserName;
                        site.ModifyDate = DateTime.Now;
                        site.Valid = false;
                        WcfServiceHelper.Client.UpdateSite(site);
                        BindList();
                        treeListData.ExpandAll();
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

        #endregion

        #region 方法

        void BindList()
        {
            dataSource = FrequentlyUsedData.GetSiteList(true).Where(obj => obj.Valid == true).ToList();
            treeListData.DataSource = dataSource;
        }

        void BindParameter()
        {
            List<SysParameter> lstProvince = FrequentlyUsedData.GetParameterList("Province", false);
            (treeListData.Columns["Province"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstProvince;

            dataSourceCity = FrequentlyUsedData.GetParameterList("City", false);
            (treeListData.Columns["City"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = dataSourceCity;

            List<SysParameter> lstSiteType = FrequentlyUsedData.GetParameterList("SiteType", false);
            (treeListData.Columns["Type"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstSiteType;

            List<SysParameter> lstCurrency = FrequentlyUsedData.GetParameterList("Currency", false);
            (treeListData.Columns["Currency"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstCurrency;
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
