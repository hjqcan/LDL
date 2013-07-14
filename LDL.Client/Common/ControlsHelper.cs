using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using LDL.Client.LDLService;
using LDL.Client.UserControls.Common;
using System.Windows.Forms;

namespace LDL.Client.Common
{
    public class ControlsHelper
    {
        #region 工具栏事件
        private static EventHandlerList eventHandlerList = new EventHandlerList();
        public static void AddEvent(BarBaseButtonItem control, ItemClickEventHandler eventhandler)
        {
            Delegate delegateList = eventHandlerList[control.Name];
            if (delegateList != null)
            {
                foreach (Delegate d in delegateList.GetInvocationList())
                    control.ItemClick -= (ItemClickEventHandler)d;
                eventHandlerList.RemoveHandler(control.Name, delegateList);
            }

            control.ItemClick += eventhandler;
            eventHandlerList.AddHandler(control.Name, eventhandler);
        }
        #endregion

        /// <summary>
        /// 清空控件值
        /// </summary>
        public static void ResetControls(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                if (control.GetType() == typeof(DevExpress.XtraEditors.TextEdit))
                    (control as TextEdit).Text = "";
                else if (control.GetType() == typeof(DevExpress.XtraEditors.SpinEdit))
                    (control as SpinEdit).Value = (control as SpinEdit).Properties.MinValue;
                else if (control.GetType() == typeof(DevExpress.XtraEditors.CheckEdit))
                    (control as CheckEdit).Checked = false;
                else if (control.GetType() == typeof(DevExpress.XtraEditors.LookUpEdit))
                    (control as LookUpEdit).EditValue = null;
                else if (control.GetType() == typeof(DevExpress.XtraEditors.PopupContainerEdit))
                {
                    (control as PopupContainerEdit).EditValue = null;
                    (control as PopupContainerEdit).Tag = null;
                }
                else if (control.GetType() == typeof(ButtonEdit))
                {
                    (control as ButtonEdit).EditValue = null;
                    (control as ButtonEdit).Tag = null;
                }
            }
        }

        #region 控件数据绑定

        static Dictionary<string, List<SysParameter>> dictParameter = new Dictionary<string, List<SysParameter>>();

        /// <summary>
        /// 按参数表绑定LookUpEdit控件
        /// </summary>
        /// <param name="control">LookUpEdit控件</param>
        /// <param name="type">参数类型</param>
        /// <param name="isRefreshData">是否刷新数据</param>
        public static void BindLookUpByParameter(LookUpEdit control, string type, AppendType appendType, bool isRefreshData)
        {
            //加载数据
            if (!dictParameter.ContainsKey(type) || isRefreshData)
            {
                List<SysParameter> _lstParameter = WcfServiceHelper.Client.GetParameterListByType(type).ToList();
                dictParameter.Add(type, _lstParameter);
            }

            List<SysParameter> lstParameter = dictParameter[type].OrderBy(obj => obj.OrderID).ToList();
            if (appendType != AppendType.None)
            {
                SysParameter para = new SysParameter();
                para.Code = "";
                if (appendType == AppendType.All)
                {
                    para.DisplayName = "全部";
                    para.FullName = "全部";
                }
                else if (appendType == AppendType.Blank)
                {
                    para.DisplayName = "";
                    para.FullName = "";
                }
                lstParameter.Insert(0, para);
            }

            control.Properties.DataSource = lstParameter;
        }

        /// <summary>
        /// 按参数表绑定LookUpEdit控件
        /// </summary>
        /// <param name="control">LookUpEdit控件</param>
        /// <param name="type">参数类型</param>
        public static void BindLookUpByParameter(LookUpEdit control, string type)
        {
            BindLookUpByParameter(control, type, AppendType.None, false);
        }


        #endregion


        #region 对话框

        public static void ShowMessage(string caption, string msg)
        {
            XtraMessageBox.Show(msg, caption, System.Windows.Forms.MessageBoxButtons.OK);
        }

        public static void ShowErrorMessage(string caption, string msg)
        {
            XtraMessageBox.Show(msg, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void ShowWarningMessage(string caption, string msg)
        {
            XtraMessageBox.Show(msg, caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public static System.Windows.Forms.DialogResult ShowConfirmMessage(string caption, string msg)
        {
            return XtraMessageBox.Show(msg, caption, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
        }

        public static void ShowAlertMessage(System.Windows.Forms.Form form, string caption, string msg)
        {
            new DevExpress.XtraBars.Alerter.AlertControl().Show(form, caption, msg);
        }

        #endregion

        #region 站点、部门、客户绑定

        /// <summary>
        /// 初始化站点
        /// </summary>
        public static void InitControlSite(ButtonEdit controlSite)
        {
            controlSite.Properties.ReadOnly = true;
            controlSite.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(controlSite_ButtonClick);
        }
        static FrmSite frmSite;
        static void controlSite_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (frmSite == null)
                    frmSite = new FrmSite();
                frmSite.SelectedItem = (sender as ButtonEdit).Tag;
                if (frmSite.ShowDialog() == DialogResult.OK)
                {
                    CoSite obj = frmSite.SelectedItem as CoSite;
                    (sender as ButtonEdit).Tag = obj;
                    (sender as ButtonEdit).EditValue = obj.Name;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("错误", ex.Message);
            }
        }

        /// <summary>
        /// 初始化部门
        /// </summary>
        public static void InitControlDepartment(ButtonEdit controlDept)
        {
            controlDept.Properties.ReadOnly = true;
            controlDept.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(controlDept_ButtonClick);
        }
        static FrmDepartment frmDepartment;
        static void controlDept_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (frmDepartment == null)
                    frmDepartment = new FrmDepartment();
                frmDepartment.SelectedItem = (sender as ButtonEdit).Tag;
                if (frmDepartment.ShowDialog() == DialogResult.OK)
                {
                    CoDepartment obj = frmDepartment.SelectedItem as CoDepartment;
                    (sender as ButtonEdit).Tag = obj;
                    (sender as ButtonEdit).EditValue = obj.DeptName;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("错误", ex.Message);
            }
        }

        /// <summary>
        /// 初始化客户
        /// </summary>
        public static void InitControlCustomers(ButtonEdit controlCustomers)
        {
            controlCustomers.Properties.ReadOnly = true;
            controlCustomers.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(controlCustomers_ButtonClick);
        }
        static FrmCustomers frmCustomers;
        static void controlCustomers_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (frmCustomers == null)
                    frmCustomers = new FrmCustomers(false);
                frmCustomers.SelectedItem = (sender as ButtonEdit).Tag;
                if (frmCustomers.ShowDialog() == DialogResult.OK)
                {
                    CoCustomers obj = frmCustomers.SelectedItem as CoCustomers;
                    (sender as ButtonEdit).Tag = obj;
                    (sender as ButtonEdit).EditValue = obj.Name;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("错误", ex.Message);
            }
        }

        /// <summary>
        /// 初始化目的地
        /// </summary>
        public static void InitControlDestination(ButtonEdit controlDestination)
        {
            controlDestination.Properties.ReadOnly = true;
            controlDestination.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(controlDestination_ButtonClick);
        }
        static FrmDestination frmDestination;
        static void controlDestination_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (frmDestination == null)
                    frmDestination = new FrmDestination(false);
                frmDestination.SelectedItem = (sender as ButtonEdit).Tag;
                if (frmDestination.ShowDialog() == DialogResult.OK)
                {
                    CoDestination obj = frmDestination.SelectedItem as CoDestination;
                    (sender as ButtonEdit).Tag = obj;
                    (sender as ButtonEdit).EditValue = obj.Name;
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("错误", ex.Message);
            }
        }
        #endregion
    }

    public enum AppendType
    {
        None,
        Blank,
        All
    }
}
