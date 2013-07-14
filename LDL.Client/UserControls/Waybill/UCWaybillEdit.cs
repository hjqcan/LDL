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

namespace LDL.Client.UserControls.Waybill
{
    public partial class UCWaybillEdit : DevExpress.XtraEditors.XtraUserControl
    {
        BindingList<WaybillGoods> lstWaybillGoods = new BindingList<WaybillGoods>();

        public UCWaybillEdit()
        {
            InitializeComponent();
        }

        private void UCWaybillEdit_Load(object sender, EventArgs e)
        {
            BindParameter();
            gridGoods.DataSource = lstWaybillGoods;
            ControlsHelper.InitControlCustomers(btneConsignor);
            ControlsHelper.InitControlSite(btneDestinationSite);
            ControlsHelper.InitControlDestination(btneDestination);
        }

        #region 事件

        //获取运单编号
        private void lnkCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Identity.CurrentEmployee == null)
            {
                ControlsHelper.ShowErrorMessage("获取失败", "获取用户所属站点失败");
                return;
            }

            string code = WcfServiceHelper.Client.GetFirstWaybillCodeBySite(Identity.CurrentEmployee.SiteID);
            if (string.IsNullOrEmpty(code))
                ControlsHelper.ShowWarningMessage("运单编号获取失败", "没有可用的运单编号");
            else
                txtCode.Text = code;
        }

        //选择目的地
        private void btneDestination_EditValueChanged(object sender, EventArgs e)
        {
            CoDestination destination = btneDestination.Tag as CoDestination;
            if (destination != null)
            {
                CoSite site = FrequentlyUsedData.GetSiteList(false).Find(obj => obj.ID == destination.SiteID);
                if (site != null)
                {
                    btneDestinationSite.Tag = site;
                    btneDestinationSite.EditValue = site.Name;
                }
            }
        }

        //选择发货方
        private void btneConsignor_EditValueChanged(object sender, EventArgs e)
        {
            CoCustomers customers = btneConsignor.Tag as CoCustomers;
            if (customers != null)
            {
                txtConsignorLinkMan.Text = customers.LinkMan1;
                txtConsignorTel.Text = customers.Tel1;
                txtConsignorPhone.Text = customers.Phone1;
                txtConsignorAddress.Text = customers.Address;
                txtCustomersType.Text = customers.CustomersType;
                lueSettlementType.EditValue = customers.SettlementType;
                lueServiceEmployee.EditValue = customers.ServiceEmployeeID;
            }
        }

        private void gvGoods_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Volume" || e.Column.FieldName == "Weight")
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //计价重量
                    WaybillGoods goods = gvGoods.GetRow(e.RowHandle) as WaybillGoods;
                    goods.RealWeight = goods.Volume * 167 > goods.Weight ? goods.Volume * 167 : goods.Weight;
                    if (lueLogisticsType.EditValue != null)
                    {
                        //中转费
                        decimal arbitariec = ComputeFee("中转费", goods);
                        if (arbitariec != 0)
                            goods.Arbitariec = arbitariec;
                        //派件费
                        decimal dispatchFee = ComputeFee("派件费", goods);
                        if (dispatchFee != 0)
                            goods.DispatchFee = dispatchFee;
                    }
                }
                catch (Exception ex)
                {
                    ControlsHelper.ShowErrorMessage("", ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }

            seReceivableAmount.Value = GetTotalMoney();
        }

        //计算费用
        decimal ComputeFee(string feeType, WaybillGoods goods)
        {
            CoSite srcSite = FrequentlyUsedData.GetSiteList(false).FirstOrDefault(obj => obj.ID == Identity.CurrentEmployee.SiteID);
            CoDestination dest = (btneDestination.Tag as CoDestination);
            CoCustomers customers = (btneConsignor.Tag as CoCustomers);
            if (dest != null && customers != null)
            {
                //验证一下~~~~~~~~~~~
                List<QuoteExpression> lstQuoteExpression = FrequentlyUsedData.GetQuoteExpressionList(false).ToList();
                List<QuoteMainRelation> lstQuoteMainRelation = FrequentlyUsedData.GetQuoteMainRelationList(false).ToList();
                //该站点相关站点
                List<string> lstSite = CommonHelper.GetSiteRelation(srcSite.ID).ConvertAll(obj => obj.ID);
                List<string> lstQuoteMainSite = lstQuoteMainRelation.Where(obj => obj.Type == "寄件站点" && lstSite.Contains(obj.Code)).ToList().ConvertAll(obj => obj.SrcID);
                //目的地一致的报价单ID
                List<string> lstQuoteMainDest = lstQuoteMainRelation.Where(obj => obj.Type == "派件区域" && obj.Code == dest.ID.ToString()).ToList().ConvertAll(obj => obj.SrcID);
                //客户一致的报价单ID
                List<string> lstQuoteMainCustomers = lstQuoteMainRelation.Where(obj => obj.Type == "报价客户" && obj.Code == customers.ID.ToString()).ToList().ConvertAll(obj => obj.SrcID);
                //取出 订单类型、派送类别、费用类型 ，在该目的地内的报价单
                List<QuoteMain> lstQuoteMain = FrequentlyUsedData.GetQuoteMainList(false).
                    Where(obj => obj.FeeType == feeType && obj.LogisticsType == lueLogisticsType.EditValue.ToString() &&
                        obj.DispatchType == lueDispatchType.EditValue.ToString() && lstQuoteMainDest.Contains(obj.Guid)).ToList();

                //如果有针对该客户的报价单、优先处理
                if (lstQuoteMain.Count(obj => lstQuoteMainCustomers.Contains(obj.Guid) && lstQuoteMainSite.Contains(obj.Guid)) > 0)
                {
                    //客户与站点对应的报价单交集
                    List<string> lstQuoteMainIntersect = lstQuoteMainSite.Intersect(lstQuoteMainCustomers).ToList();
                    foreach (string siteCode in lstSite)    //按站点顺序从低到高
                    {
                        QuoteMainRelation r = lstQuoteMainRelation.FirstOrDefault(obj => obj.Type == "寄件站点" && obj.Code == siteCode && lstQuoteMainIntersect.Contains(obj.SrcID));
                        if (r != null)
                        {
                            QuoteMain q = lstQuoteMain.FirstOrDefault(obj => obj.Guid == r.SrcID);
                            //开始计算
                            return quoteCompute(q, goods);
                        }
                    }
                }
                //没有针对该客户的报价单，查找那些客户为空的报价单
                else
                {
                    foreach (string siteID in lstSite)    //按站点顺序从低到高
                    {
                        List<string> lstQuoteMainCurrentSite = lstQuoteMainRelation.Where(obj => obj.Type == "寄件站点" && obj.Code == siteID).ToList().ConvertAll(obj => obj.SrcID);
                        foreach (string s in lstQuoteMainCurrentSite)
                        {
                            //当前报价单存在并且不含客户资料
                            QuoteMain q = lstQuoteMain.FirstOrDefault(obj => obj.Guid == s);
                            if (q != null && lstQuoteMainRelation.Count(obj => obj.Type == "报价客户" && obj.SrcID == q.Guid) == 0)
                            {
                                //开始计算
                                return quoteCompute(q, goods);
                            }
                        }

                    }
                }
            }
            return 0;
        }

        decimal quoteCompute(QuoteMain quoteMain, WaybillGoods goods)
        {
            decimal result = 0;
            List<QuoteExpression> lstQuoteExpression = FrequentlyUsedData.GetQuoteExpressionList(false).Where(obj => obj.SrcID == quoteMain.Guid).ToList();
            if (goods.RealWeight != 0 && lstQuoteExpression.Count > 0)
            {
                result = CommonHelper.ComputeQuoteByExpression(goods.RealWeight, lstQuoteExpression);
            }
            return result;
        }

        //计算总额
        void CalculateMoney(object sender, EventArgs e)
        {
            seReceivableAmount.Value = GetTotalMoney();
        }

        //保存
        void _barbtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (validationProvider.Validate() && validate())
                {
                    WaybillInfo waybillInfo = new WaybillInfo();

                    #region 发货方
                    waybillInfo.Code = txtCode.Text.Trim();
                    waybillInfo.ConsignorSite = Identity.CurrentEmployee.SiteID;
                    waybillInfo.CustomersType = txtCustomersType.Text;
                    waybillInfo.LogisticsType = lueLogisticsType.EditValue.ToString();
                    waybillInfo.DispatchType = lueDispatchType.EditValue.ToString();
                    waybillInfo.SettlementType = lueSettlementType.EditValue.ToString();
                    waybillInfo.Consignor = (btneConsignor.Tag as CoCustomers).ID;
                    waybillInfo.ConsignorLinkMan = txtConsignorLinkMan.Text.Trim();
                    waybillInfo.ConsignorTel = txtConsignorTel.Text.Trim();
                    waybillInfo.ConsignorPhone = txtConsignorPhone.Text.Trim();
                    waybillInfo.ConsignorAddress = txtConsignorAddress.Text.Trim();
                    if (lueServiceEmployee.Tag == null)
                        waybillInfo.ServiceEmployee = null;
                    else
                        waybillInfo.ServiceEmployee = (lueServiceEmployee.Tag as CoEmployee).ID;
                    if (lueSalesmanEmployee.Tag == null)
                        waybillInfo.SalesmanEmployee = null;
                    else
                        waybillInfo.SalesmanEmployee = (lueSalesmanEmployee.Tag as CoEmployee).ID;
                    #endregion
                    #region 收货方
                    waybillInfo.DestinationSite = (btneDestinationSite.Tag as CoSite).ID;
                    waybillInfo.Destination = (btneDestination.Tag as CoDestination).ID;
                    waybillInfo.Consignee = cbxConsignee.Text;
                    waybillInfo.ConsigneeLinkMan = txtConsigneeLinkMan.Text.Trim();
                    waybillInfo.ConsigneeTel = txtConsigneeTel.Text.Trim();
                    waybillInfo.ConsigneeAddress = memoConsigneeAddress.Text.Trim();
                    #endregion
                    #region 费用信息
                    waybillInfo.StorageFee = seStorageFee.Value;
                    waybillInfo.ReceiptFee = seReceiptFee.Value;
                    waybillInfo.RemoteFee = seRemoteFee.Value;
                    waybillInfo.OtherFee = seOtherFee.Value;
                    waybillInfo.TakeTheirFee = seTakeTheirFee.Value;
                    waybillInfo.PickUpGoodsFee = sePickUpGoodsFee.Value;
                    waybillInfo.DeliveryRMBFee = seDeliveryRMBFee.Value;
                    waybillInfo.DeliveryHKDFee = seDeliveryHKDFee.Value;
                    waybillInfo.CustomsDlearanceFee = seCustomsDlearanceFee.Value;
                    waybillInfo.AdditionalPage = Convert.ToInt16(seAdditionalPage.Value);
                    waybillInfo.AdditionalPageFee = seAdditionalPageFee.Value;
                    waybillInfo.ProtocolNo = txtProtocolNo.Text.Trim();
                    waybillInfo.ReceivableAmount = seReceivableAmount.Value;
                    waybillInfo.PaidAmount = sePaidAmount.Value;
                    waybillInfo.PaymentFlag = cePaymentFlag.Checked;
                    #endregion
                    #region 其它信息
                    waybillInfo.DispatchUnifiedNum = txtDispatchUnifiedNum.Text.Trim();
                    waybillInfo.DispatchAttachment = txtDispatchAttachment.Text.Trim();
                    waybillInfo.DispatchEntrancePermit = txtDispatchEntrancePermit.Text.Trim();
                    waybillInfo.DispatchReceiptAddress = txtDispatchReceiptAddress.Text.Trim();
                    waybillInfo.ReceiptFlag = ceReceiptFlag.Checked;
                    waybillInfo.ReceiptCode = txtReceiptCode.Text.Trim();
                    waybillInfo.Remark = txtRemark.Text.Trim();
                    waybillInfo.CreateUser = Identity.CurrentUser.UserName;
                    waybillInfo.CreateDate = DateTime.Now;
                    #endregion

                    foreach (WaybillGoods goods in lstWaybillGoods)
                    {
                        goods.WaybillCode = waybillInfo.Code;
                        goods.Valid = true;
                    }

                    WcfServiceHelper.Client.InsertWaybillInfo(waybillInfo, lstWaybillGoods.ToArray());
                    ClearPanel(groupControlConsignor.Controls);
                    ClearPanel(groupControlConsignee.Controls);
                    ClearPanel(groupControlFee.Controls);
                    ClearPanel(groupControlOther.Controls);
                    ControlsHelper.ShowAlertMessage(this.ParentForm, "保存", "保存成功");
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



        #endregion

        #region 方法

        void ClearPanel(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(TextEdit))
                    (control as TextEdit).Text = "";
                else if (control.GetType() == typeof(LookUpEdit))
                    (control as LookUpEdit).EditValue = null;
                else if (control.GetType() == typeof(ButtonEdit))
                    (control as ButtonEdit).EditValue = null;
                else if (control.GetType() == typeof(SpinEdit))
                    (control as SpinEdit).EditValue = 0;
                else if (control.GetType() == typeof(ComboBoxEdit))
                    (control as ComboBoxEdit).Text = "";
            }
        }

        void BindList()
        {
        }

        void BindParameter()
        {
            //客服
            List<CoEmployee> lstEmployee1 = FrequentlyUsedData.GetEmployeeByDepartment(AppendType.Blank, 1, false);
            lueServiceEmployee.Properties.DataSource = lstEmployee1;
            //业务员
            List<CoEmployee> lstEmployee2 = FrequentlyUsedData.GetEmployeeByDepartment(AppendType.Blank, 2, false);
            lueSalesmanEmployee.Properties.DataSource = lstEmployee2;
            //订单类型
            List<SysParameter> lstLogisticsType = FrequentlyUsedData.GetParameterList("WayBillLogisticsType", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            lueLogisticsType.Properties.DataSource = lstLogisticsType;
            //派送类别
            List<SysParameter> lstDispatchType = FrequentlyUsedData.GetParameterList("WayBillDispatchType", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            lueDispatchType.Properties.DataSource = lstDispatchType;
            //支付方式
            List<SysParameter> lstSettlementType = FrequentlyUsedData.GetParameterList("WayBillSettlement", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            lueSettlementType.Properties.DataSource = lstSettlementType;
            //货物类型
            List<SysParameter> lstWayBillGoods = FrequentlyUsedData.GetParameterList("WayBillGoods", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            (gvGoods.Columns["Goods"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstWayBillGoods;
            //包装
            List<SysParameter> lstWaybillPack = FrequentlyUsedData.GetParameterList("WaybillPack", false, AppendType.Blank).Where(obj => obj.Valid == true).ToList();
            (gvGoods.Columns["Pack"].ColumnEdit as DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit).DataSource = lstWaybillPack;
        }

        /// <summary>
        /// 保存验证
        /// </summary>
        bool validate()
        {

            #region 货物
            if (lstWaybillGoods.Count == 0)
            {
                ControlsHelper.ShowWarningMessage("验证失败", "请添加货物信息");
                return false;
            }

            foreach (WaybillGoods goods in lstWaybillGoods)
            {
                if (string.IsNullOrEmpty(goods.Goods))
                {
                    ControlsHelper.ShowWarningMessage("验证失败", "请选择货物名称");
                    return false;
                }
                else if (goods.Number <= 0)
                {
                    ControlsHelper.ShowWarningMessage("验证失败", "请输入货物数量");
                    return false;
                }
                else if (goods.RealWeight <= 0)
                {
                    ControlsHelper.ShowWarningMessage("验证失败", "请输入货物体积或重量");
                    return false;
                }
                else if (goods.Arbitariec <= 0)
                {
                    ControlsHelper.ShowWarningMessage("验证失败", "请输入中转费用");
                    return false;
                }
            }

            #endregion


            return true;
        }

        /// <summary>
        /// 计算总额
        /// </summary>
        decimal GetTotalMoney()
        {
            decimal totalMoney = seStorageFee.Value + seReceiptFee.Value + seRemoteFee.Value + seOtherFee.Value +
                seTakeTheirFee.Value + sePickUpGoodsFee.Value + seDeliveryRMBFee.Value + seDeliveryHKDFee.Value +
                seCustomsDlearanceFee.Value + seAdditionalPageFee.Value;
            foreach (WaybillGoods goods in lstWaybillGoods)
            {
                totalMoney += goods.Arbitariec;
                totalMoney += goods.DispatchFee;
            }
            return totalMoney;
        }

        #endregion

        #region 初始化工具栏，用继承类界面设计报错...

        /// <summary>
        /// 初始化工具栏，用继承类界面设计报错...
        /// </summary>
        public void InitToolbar()
        {
            ToolbarHelper.InitToolbar(this);
            ControlsHelper.AddEvent(FrmMain._barbtnSave, _barbtnSave_ItemClick);
        }

        #endregion









    }
}
