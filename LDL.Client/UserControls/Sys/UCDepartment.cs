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
    public partial class UCDepartment : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<CoDepartment> dataSource;

        #endregion

        public UCDepartment()
        {
            InitializeComponent();
        }

        #region 事件

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
                ControlsHelper.ShowWarningMessage("提醒", "请点击新增部门的上级部门");
            }
            else
            {
                int id = int.Parse(treeListData.FocusedNode["ID"].ToString());
                FrmDepartmentEdit frm = new FrmDepartmentEdit(DBOperateType.Insert, null, id);
                if (frm.ShowDialog() == DialogResult.OK)
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
                ControlsHelper.ShowWarningMessage("提醒", "请点击修改的部门");
            }
            else
            {
                int id = int.Parse(treeListData.FocusedNode["ID"].ToString());
                CoDepartment dept = dataSource.Find(obj => obj.ID == id);
                FrmDepartmentEdit frm = new FrmDepartmentEdit(DBOperateType.Update, dept, 0);
                if (frm.ShowDialog() == DialogResult.OK)
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
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的部门");
            }
            else if (treeListData.FocusedNode.ParentNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "顶级部门不可删除");
            }
            else
            {
                int id = int.Parse(treeListData.FocusedNode["ID"].ToString());
                CoDepartment department = dataSource.Find(obj => obj.ID == id);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除部门[{0}]吗？", department.DeptName)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        department.ModifyUser = Identity.CurrentUser.UserName;
                        department.ModifyDate = DateTime.Now;
                        department.Valid = false;
                        WcfServiceHelper.Client.UpdateDepartment(department);
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
            dataSource = FrequentlyUsedData.GetDepartmentList(true).Where(obj => obj.Valid == true).ToList();
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
