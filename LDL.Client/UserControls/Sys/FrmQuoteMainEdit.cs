using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LDL.Client.LDLService;
using LDL.Client.Common;
using LDL.Utility;
using LDL.Client.UserControls.Common;

namespace LDL.Client.UserControls.Sys
{
    public partial class FrmQuoteMainEdit : DevExpress.XtraEditors.XtraForm
    {
        string EditType;
        string Guid;
        List<CoCustomers> lstCustomers = new List<CoCustomers>();
        List<CoSite> lstSite = new List<CoSite>();
        List<CoDestination> lstDestination = new List<CoDestination>();
        QuoteMain quoteMain;

        BindingList<QuoteExpression> lstQuoteExpression = new BindingList<QuoteExpression>();

        public FrmQuoteMainEdit(string editType, string guid)
        {
            InitializeComponent();
            EditType = editType;
            Guid = guid == "" ? System.Guid.NewGuid().ToString() : guid;
            this.Text = EditType;
        }

        private void FrmQuoteMainEdit_Load(object sender, EventArgs e)
        {

            InitControls();
        }

        private void InitControls()
        {
            if (EditType == "修改")
            {
                quoteMain = WcfServiceHelper.Client.GetQuoteMain(Guid);
                if (quoteMain == null)
                {
                    ControlsHelper.ShowErrorMessage("修改失败", "该报价不存在");
                    this.Close();
                }

                txtName.Text = quoteMain.Name;
                cbxLogisticsType.Text = quoteMain.LogisticsType;
                cbxDispatchType.Text = quoteMain.DispatchType;
                cbxFeeType.Text = quoteMain.FeeType;
                List<QuoteMainRelation> quoteRelation = WcfServiceHelper.Client.GetQuoteMainRelationByID(Guid).ToList();
                //客户
                List<string> lstCustomersCode = quoteRelation.FindAll(obj => obj.Type == "报价客户").ConvertAll<string>(obj => obj.Code);
                lstCustomers = FrequentlyUsedData.GetCustomersList(false).FindAll(obj => lstCustomersCode.Contains(obj.ID.ToString()));
                lsbCustomers.DataSource = lstCustomers;
                //寄件站点
                List<string> lstSiteCode = quoteRelation.FindAll(obj => obj.Type == "寄件站点").ConvertAll<string>(obj => obj.Code);
                lstSite = FrequentlyUsedData.GetSiteList(false).FindAll(obj => lstSiteCode.Contains(obj.ID.ToString()));
                lsbSite.DataSource = lstSite;
                //派送区域
                List<string> lstDestinationCode = quoteRelation.FindAll(obj => obj.Type == "派件区域").ConvertAll<string>(obj => obj.Code);
                lstDestination = FrequentlyUsedData.GetDestinationList(false).FindAll(obj => lstDestinationCode.Contains(obj.ID.ToString()));
                lsbDestination.DataSource = lstDestination;
                //报价公式
                lstQuoteExpression = new BindingList<QuoteExpression>(WcfServiceHelper.Client.GetQuoteExpressionByID(Guid).OrderBy(obj => obj.SortID).ToList());
                gridData.DataSource = lstQuoteExpression;
            }
        }


        private void controlNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                QuoteExpression expression = new QuoteExpression();
                int maxSortID = lstQuoteExpression.Max(obj => obj.SortID);
                expression.SortID = maxSortID + 1;
                lstQuoteExpression.Add(expression);
                e.Handled = true;
            }
        }

        private void lnkCheckExpression_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                decimal w = Convert.ToDecimal(spinEditWeight.Value);
                decimal result = CheckExpression(w);
                ControlsHelper.ShowMessage("检验通过", string.Format("设重量w={0}，得到的结果为:{1}", w, result));
            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("检验失败", ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 检查表达式
        /// </summary>
        private decimal CheckExpression(decimal w)
        {
            
            try
            {
                List<QuoteExpression> expressions = lstQuoteExpression.OrderBy(obj => obj.SortID).ToList();
                return CommonHelper.ComputeQuoteByExpression(w, expressions);
            }
            catch (Exception ex)
            {
                throw ex;
                //throw new Exception(string.Format("序号[{0}]：{1}", sortID, ex.Message));
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (validationProvider.Validate())
                {
                    #region 检验
                    if (lstSite.Count == 0)
                    {
                        ControlsHelper.ShowWarningMessage("保存失败", "请添加寄件站点");
                        return;
                    }
                    if (lstDestination.Count == 0)
                    {
                        ControlsHelper.ShowWarningMessage("保存失败", "请添加派件区域");
                        return;
                    }

                    try
                    {
                        decimal result = CheckExpression(88.88M);
                    }
                    catch (Exception ex)
                    {
                        ControlsHelper.ShowErrorMessage("保存失败", ex.Message);
                        return;
                    }
                    #endregion

                    //保存
                    if (quoteMain == null)
                    {
                        quoteMain = new QuoteMain();
                        quoteMain.CreateUser = Identity.CurrentUser.UserName;
                        quoteMain.CreateDate = DateTime.Now;
                        quoteMain.Guid = Guid;
                        quoteMain.Valid = true;
                    }
                    quoteMain.Name = txtName.Text.Trim();
                    quoteMain.FeeType = cbxFeeType.Text;
                    quoteMain.LogisticsType = cbxLogisticsType.Text;
                    quoteMain.DispatchType = cbxDispatchType.Text;

                    #region 寄件站点、收件站点、客户
                    List<QuoteMainRelation> quoteRelation = new List<QuoteMainRelation>();
                    foreach (CoSite site in lstSite)
                    {
                        QuoteMainRelation r = new QuoteMainRelation();
                        r.SrcID = Guid;
                        r.Code = site.ID;
                        r.Type = "寄件站点";
                        quoteRelation.Add(r);
                    }
                    foreach (CoDestination destination in lstDestination)
                    {
                        QuoteMainRelation r = new QuoteMainRelation();
                        r.SrcID = Guid;
                        r.Code = destination.ID.ToString();
                        r.Type = "派件区域";
                        quoteRelation.Add(r);
                    }
                    foreach (CoCustomers customers in lstCustomers)
                    {
                        QuoteMainRelation r = new QuoteMainRelation();
                        r.SrcID = Guid;
                        r.Code = customers.ID.ToString();
                        r.Type = "报价客户";
                        quoteRelation.Add(r);
                    }
                    #endregion

                    #region 条件表达式
                    List<QuoteExpression> quoteExpressions = new List<QuoteExpression>();
                    foreach (QuoteExpression expression in lstQuoteExpression)
                    {
                        QuoteExpression obj = new QuoteExpression();
                        obj.Guid = System.Guid.NewGuid().ToString();
                        obj.SrcID = Guid;
                        obj.SortID = expression.SortID;
                        obj.Condition = expression.Condition;
                        obj.Expression = expression.Expression;
                        quoteExpressions.Add(obj);
                    }
                    #endregion

                    if (EditType == "修改")
                        WcfServiceHelper.Client.UpdateQuoteMain(quoteMain, quoteRelation.ToArray(), quoteExpressions.ToArray());
                    else
                        WcfServiceHelper.Client.InsertQuoteMain(quoteMain, quoteRelation.ToArray(), quoteExpressions.ToArray());

                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                ControlsHelper.ShowErrorMessage("保存失败", ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 增加客户，站点等
        /// </summary>
        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            ListBoxControl control = contextMenu.SourceControl as ListBoxControl;
            if (control.Tag.ToString() == "寄件站点")
            {
                FrmSite frm = new FrmSite(true);
                frm.SelectedItem = lstSite;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lstSite = frm.SelectedItem as List<CoSite>;
                    control.DataSource = lstSite;
                }
            }
            else if (control.Tag.ToString() == "派件区域")
            {
                FrmDestination frm = new FrmDestination();
                frm.SelectedItem = lstDestination;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lstDestination = frm.SelectedItem as List<CoDestination>;
                    control.DataSource = lstDestination;
                }
            }
            else if (control.Tag.ToString() == "报价客户")
            {
                FrmCustomers frm = new FrmCustomers();
                frm.SelectedItem = lstCustomers;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    lstCustomers = frm.SelectedItem as List<CoCustomers>;
                    control.DataSource = lstCustomers;
                }
            }
        }

        /// <summary>
        /// 删除客户，站点等
        /// </summary>
        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            ListBoxControl control = contextMenu.SourceControl as ListBoxControl;
            if (control.Tag.ToString() == "寄件站点")
            {
                object val = control.SelectedItem;
                if (val != null)
                    lstSite.Remove(val as CoSite);
            }
            else if (control.Tag.ToString() == "派件区域")
            {
                object val = control.SelectedItem;
                if (val != null)
                    lstDestination.Remove(val as CoDestination);
            }
            else if (control.Tag.ToString() == "报价客户")
            {
                object val = control.SelectedItem;
                if (val != null)
                    lstCustomers.Remove(val as CoCustomers);
            }
        }

        /// <summary>
        /// 费用类型变更
        /// </summary>
        private void cbxFeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDispatchType.Properties.Items.Clear();
            if (cbxFeeType.Text == "中转费")
                cbxDispatchType.Properties.Items.AddRange(new string[] { "派送", "自提" });
            else if (cbxFeeType.Text == "派件费")
                cbxDispatchType.Properties.Items.AddRange(new string[] { "派送", "自提", "码头仓", "机场仓", "私人仓", "其它" });
        }
    }
}