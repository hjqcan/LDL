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
using DevExpress.XtraBars.Alerter;

namespace LDL.Client.UserControls.Sys
{
    public partial class UCFunction : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<SysFunction> dataSource;

        #endregion

        public UCFunction()
        {
            InitializeComponent();
        }

        #region 事件

        private void UCFunction_Load(object sender, EventArgs e)
        {
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
                ControlsHelper.ShowWarningMessage("提醒", "请点击新增菜单的上级或同级菜单");
            }
            else
            {
                string code = treeListData.FocusedNode.ParentNode == null ?
                    treeListData.FocusedNode["Code"].ToString() : treeListData.FocusedNode.ParentNode["Code"].ToString();

                FrmFunctionEdit frmFunction = new FrmFunctionEdit(DBOperateType.Insert, null, code);
                if (frmFunction.ShowDialog() == DialogResult.OK)
                {
                    BindList();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "新增", "新增成功");
                }
            }
            this.Cursor = Cursors.Default;
        }

        //修改
        void _barbtnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的菜单");
            }
            else
            {
                string code = treeListData.FocusedNode["Code"].ToString();
                SysFunction function = dataSource.Find(obj => obj.Code == code);
                FrmFunctionEdit frmFunction = new FrmFunctionEdit(DBOperateType.Update, function, null);
                if (frmFunction.ShowDialog() == DialogResult.OK)
                {
                    BindList();
                    treeListData.ExpandAll();
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "修改", "修改成功");
                }
            }
            this.Cursor = Cursors.Default;
        }

        //删除
        void _barbtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的菜单");
            }
            else if (treeListData.FocusedNode.ParentNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "菜单组不可删除");
            }
            else
            {
                string code = treeListData.FocusedNode["Code"].ToString();
                SysFunction function = dataSource.Find(obj => obj.Code == code);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除菜单[{0}]吗？", function.Name)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        WcfServiceHelper.Client.DeleteFunction(code);
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
            dataSource = WcfServiceHelper.Client.GetFunctionList().OrderBy(obj=>obj.OrderID).ToList();
            treeListData.DataSource = dataSource;
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
