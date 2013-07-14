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
    public partial class UCParameter : DevExpress.XtraEditors.XtraUserControl
    {
        #region 属性

        List<SysParameter> dataSource;
        List<SysParameterType> parameterTypeList;
        SysParameterType parameterType;
        Dictionary<string, object> dictQuery = new Dictionary<string, object>();

        #endregion

        public UCParameter()
        {
            InitializeComponent();
            InitControls();
        }

        #region 事件

        private void UCFunction_Load(object sender, EventArgs e)
        {
        }

        //查询
        void _barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lookUpQueryType.EditValue == null)
                return;

            this.Cursor = Cursors.WaitCursor;
            try
            {
                txtQueryDisplayName.Text = txtQueryDisplayName.Text.Trim();
                dictQuery[lookUpQueryType.Name] = lookUpQueryType.EditValue.ToString();
                dictQuery[txtQueryDisplayName.Name] = txtQueryDisplayName.Text.Trim();

                BindList();
                treeListData.ExpandAll();
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
            if (dataSource == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请查询后再新增");
            }
            else if (parameterType.TreeFlag && treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击新增项的上级项");
            }
            else
            {
                FrmParameterEdit frm = new FrmParameterEdit(DBOperateType.Insert, null, dictQuery[lookUpQueryType.Name].ToString());
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
                ControlsHelper.ShowWarningMessage("提醒", "请选中修改的项");
            }
            else if (parameterType.TreeFlag && treeListData.FocusedNode.ParentNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "根节点不允许修改");
            }
            else
            {
                int id = int.Parse(treeListData.FocusedNode["ID"].ToString());
                SysParameter parameter = dataSource.Find(obj => obj.ID == id);

                FrmParameterEdit frm = new FrmParameterEdit(DBOperateType.Update, parameter, null);
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
            if (treeListData.FocusedNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请点击要删除的项");
            }
            else if (parameterType.TreeFlag && treeListData.FocusedNode.ParentNode == null)
            {
                ControlsHelper.ShowWarningMessage("提醒", "根节点不允许删除");
            }
            else if (treeListData.FocusedNode.HasChildren)
            {
                ControlsHelper.ShowWarningMessage("提醒", "请先删除该项下的子项");
            }
            else
            {
                int id = int.Parse(treeListData.FocusedNode["ID"].ToString());
                SysParameter parameter = dataSource.Find(obj => obj.ID == id);

                if (ControlsHelper.ShowConfirmMessage("确认", string.Format("确定要删除[{0}]吗？\r\n如果数据已被引用，建议把数据设为“无效”状态即可", parameter.DisplayName)) == DialogResult.Yes)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        parameter.ModifyUser = Identity.CurrentUser.UserName;
                        parameter.ModifyDate = DateTime.Now;
                        parameter.Valid = false;
                        WcfServiceHelper.Client.UpdateParameter(parameter);
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
        #endregion

        #region 方法

        void BindList()
        {
            string type = dictQuery[lookUpQueryType.Name].ToString();
            string name = dictQuery[txtQueryDisplayName.Name].ToString();
            dataSource = FrequentlyUsedData.GetParameterList(type,true).Where(obj=>obj.Valid == true).ToList().OrderBy(obj => obj.OrderID).ToList();
            parameterType = parameterTypeList.Find(obj => obj.Type == type);
            if (parameterType.TreeFlag)
            {
                SysParameter rootParameter = new SysParameter();
                rootParameter.Code = "0";
                rootParameter.DisplayName = "根节点";
                rootParameter.Valid = true;
                dataSource.Insert(0, rootParameter);
            }

            if (string.IsNullOrEmpty(name))
                treeListData.DataSource = dataSource;
            else
                treeListData.DataSource = dataSource.Where(obj => obj.DisplayName.Contains(name)).ToList();
            
        }

        private void InitControls()
        {
            try
            {
                parameterTypeList = FrequentlyUsedData.GetParameterTypeList(false);
                lookUpQueryType.Properties.DataSource = parameterTypeList;
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("初始化控件数据失败", ex.Message);
            }
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

        private void lookUpQueryType_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            SysParameterType paraType = parameterTypeList.Find(obj => obj.Type == e.NewValue.ToString());
            if (paraType.TreeFlag)
            {
                txtQueryDisplayName.Text = "";
                txtQueryDisplayName.Enabled = false;
            }
            else
            {
                txtQueryDisplayName.Enabled = true;
            }
        }


        
    }
}
