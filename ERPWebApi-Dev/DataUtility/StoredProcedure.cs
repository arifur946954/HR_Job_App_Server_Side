namespace DataUtility
{
    public class StoredProcedure
    {
        //Auth       
        public const string SpGet_IspAllNotificationCount = "[dbo].[Get_IspAllNotificationCount]";
        public const string SpGet_IspProcessNotification = "[dbo].[Get_IspProcessNotification]";
        public const string SpGet_IspProcessNotificationNew = "[dbo].[Get_IspProcessNotificationNew]";
        public const string SpGet_IspProcessNotificationCommon = "[dbo].[Get_IspProcessNotificationCommonNew]";

        //Reset
        public const string SpSet_resetDb = "[dbo].[Set_appResetDb]";

        //GetNewid
        public const string SpGet_NewID = "[dbo].[Get_cmnNewID]";

        //Dashboard
        public const string SpGet_dashboard = "[dbo].[Get_cmnDashboard]";
        public const string SpGet_dashboardChart = "[dbo].[Get_bizClouddashboardChart]";
        public const string SpGet_dashboardBillingChart = "[dbo].[Get_BillClouddashboardChart]";
        public const string SpGet_dashboardChartPortal = "[dbo].[Get_bizCloudPortaldashboardChart]";
        public const string SpGet_dashboardChartConfiguration = "[dbo].[Get_cmnDashboardChartConfiguration]";

        // Dashboard isp portal
        public const string SpGet_bizISPPortaldashboardChart = "[dbo].[Get_bizISPPortaldashboardChart]";

        //cmnuser
        public const string SpGet_cmnUserWithPageByUserType = "[dbo].[Get_cmnUserWithPageByUserType]";
        public const string SpGet_cmnUserById = "[dbo].[Get_cmnUserById]";
        public const string SpSet_cmnDocUpload = "[dbo].[Set_cmnDocUpload]";

        #region User Registration
        public const string Ora_SpGet_EmployeeById = "GET_EMPLOYEE_BY_ID";
        public const string Ora_SpSet_CmnUser = "SET_CMN_USER";
        public const string Ora_SpGet_CmnUser = "GET_CMNUSERBYPAGE";
        //public const string Ora_SpGet_CmnUser = "Get_CmnUserByPage";
        #endregion User Registration

        //Menus
        public const string SpGet_Menu = "[dbo].[Get_cmnMenu]";
        public const string SpGet_AllMenu = "[dbo].[Get_cmnAllMenu]";
        public const string SpGet_RoleWiseMenu = "[dbo].[Get_cmnRoleWiseMenu]";

        //Modules
        public const string SpGet_ModulesByUserID = "[dbo].[Get_cmnModulesByUserID]";

        //Cloud Client       
        public const string SpGet_bizCloudUserWithPagination = "[dbo].[Get_bizCloudUserWithPagination]";
        public const string SpGet_bizCloudUserOfferWithPagination = "[dbo].[Get_bizCloudUserOfferWithPagination]";
        public const string SpGet_bilCloudUserClient = "[dbo].[Get_bilCloudUserClient]";
        public const string SpSet_billUserClientBalance = "[dbo].[Set_bilCloudUserBalance]";
        public const string SpSet_billUserClientPayment = "[dbo].[Set_billUserClientPayment]";
        public const string SpSet_billVmPaymentForPrepaidUser = "[dbo].[Set_billVmPaymentForPrepaidUser]";
        public const string SpSet_billUserClientPaymentManually = "[dbo].[Set_billUserClientPaymentManually]";
        public const string SpSet_billCloudUserClientOpeningBalancePayment = "[dbo].[Set_billCloudUserClientOpeningBalancePayment]";
        public const string SpSet_billUserClientPaymentOnly = "[dbo].[Set_billUserClientPaymentOnly]";
        public const string SpSet_RechargeBKash = "[dbo].[Set_RechargeBKash]";
        public const string SpSet_RechargeRocket = "[dbo].[Set_RechargeRocket]";
        public const string SpSet_RechargeFoster = "[dbo].[Set_RechargeFoster]";

        //Cloud Invoice
        public const string SpGet_getUserInvoiceByUserID = "[dbo].[Get_CloudUserInvoiceByUserID]";
        public const string SpGet_getUserPaymentByUserID = "[dbo].[Get_CloudUserPaymentByUserID]";
        public const string SpGet_billUserInvoice = "[dbo].[Get_bilCloudInvoice]";
        public const string SpSet_bilCloudInvoice = "[dbo].[Set_bilCloudInvoice]";
        public const string SpSet_bilCloudInvoiceUnmanaged = "[dbo].[Set_bilCloudInvoiceUnmanaged]";
        public const string SpGet_bilCldInvBycldUsrId = "[dbo].[Get_bilCloudInvoiceByCloudUserId]";
        public const string SpGet_bilCldInvDetailBycldUsrId = "[dbo].[Get_bilCloudInvoiceDetailsByCloudUserId]";
        public const string SpGet_bilCldInvDetailByInvoiceID = "[dbo].[Set_bilCloudInvoiceDetail]";
        public const string SpGet_bilCldInvDetailByInvoiceIDUnmanaged = "[dbo].[Set_bilCloudInvoiceDetailUnmanaged]";
        public const string SpGet_bilCldInvDetailMoreByUserVMId = "[dbo].[Get_bilCloudInvoiceMoreDetail]";
        public const string SpGet_bilCldInvDetailMoreByUserVMIdUnmanaged = "[dbo].[Get_bilCloudInvoiceMoreDetailUnmanaged]";
        public const string SpGet_CloudUserVmActivites = "[dbo].[Get_CloudUserVmActivites]";
        public const string SpGet_bizCloudVmStopNonStopHoursByUserVmId = "[dbo].[Get_bizCloudVmStopNonStopHoursByUserVmId]";

        public const string SpGet_accTransactions = "[dbo].[Get_accTransactions]";
        public const string SpGet_bizCloudVMHourlyDetailWithPagination = "[dbo].[Get_bizCloudVMHourlyDetailWithPagination]";
        public const string SpGet_ResetCloudUserVmHourlyDetails = "[dbo].[Set_ResetUserVmHourlyDetail]";
        //Cloud Usage
        public const string SpGet_UsageToSetInvoice = "[dbo].[Get_invUsageToSetInvoice]";

        //Cloud Activation Profile
        public const string SpGet_ActivationProfile = "[dbo].[Get_ActivationProfile]";
        //Cloud Coupon
        public const string SpSet_CloudCoupon = "[dbo].[Set_CloudCoupon]";
        public const string SpSet_ApplyCloudCoupon = "[dbo].[Set_ApplyCloudCoupon]";
        public const string SpGet_CloudUserCoupon = "[dbo].[Get_CloudUserCoupon]";
        public const string SpGet_bizCloudCouponWithPagination = "[dbo].[Get_bizCloudCouponWithPagination]";
        public const string SpGet_bizCouponTotalUsedWithPagination = "[dbo].[Get_bizCouponTotalUsedWithPagination]";

        //Cloud Package
        public const string SpGet_CloudPackage = "[dbo].[Get_bizCloudPackage]";
        public const string SpGet_IspPackage = "[dbo].[Get_bizIspPackage]";
        public const string SpGet_CloudPackageById = "[dbo].[Get_bizCloudPackageById]";
        public const string SpGet_CloudPackageWithPagination = "[dbo].[Get_bizCloudPackageWithPagination]";
        public const string SpGet_bizCloudPackageByUser = "[dbo].[Get_bizCloudPackageByUser]";

        //Cloud User Package
        public const string SpGet_bizCloudUserPackageWithPagination = "[dbo].[Get_bizCloudUserPackageWithPagination]";

        //Cloud tenant and Sub-Tenant
        public const string SpGet_CloudSubTenantWithPagination = "[dbo].[Get_CloudSubTenantWithPagination]";

        //CmnUserCloud
        public const string SpSet_billCloudUserClientOpeningBalance = "[dbo].[Set_bilCloudUserOpeningBalance]";
        public const string SpGet_IsPossibleVMDeploy = "[dbo].[Get_IsPossibleVMDeploy]";
        public const string SpSet_bizIspProfileUser = "[dbo].[Set_bizISPProfileUser]";
        public const string SpGet_bizCloudPricePlanApprovalList = "[dbo].[Get_bizCloudPricePlanApprovalList]";

        //IPTV 
        public const string SpGet_VideosByCategory = "[dbo].[Get_VideosByCategory]";

        //InvItemSale
        public const string SpGet_ItemSaleWithPage = "[dbo].[Get_invItemSaleWithPage]";
        public const string SpGet_ItemSaleById = "[dbo].[Get_invItemSaleById]";

        //ISP Client
        public const string SpGet_billISPUserClient = "[dbo].[Get_bilISPUserClient]";
        public const string SpSet_billISPUserClientBalance = "[dbo].[Set_bilISPUserBalance]";
        public const string SpSet_billISPUserClientOpeningBalance = "[dbo].[Set_bilISPUserOpeningBalance]";
        //public const string SpSet_billISPUserClientBalanceTest = "[dbo].[Set_bilISPUserBalance2]";
        public const string SpSet_billIspUserClientPayment = "[dbo].[Set_billIspUserClientPayment]";
        //public const string SpSet_billIspUserClientPaymentTest = "[dbo].[Set_billIspUserClientPayment2]";
        public const string SpSet_billIspUserClientOpeningBalancePayment = "[dbo].[Set_billIspUserClientOpeningBalancePayment]";
        public const string SpSet_billISPUserClientPaymentBKash = "[dbo].[Set_billISPUserClientPaymentBKash]";
        public const string SpSet_billIspUserClientPaymentOnly = "[dbo].[Set_billISPUserClientPaymentOnly]";
        public const string SpGet_bilIspPartialAmount = "[dbo].[Get_bilIspPartialAmount]";
        public const string SpSet_ISPRechargeBKash = "[dbo].[Set_ISPRechargeBKash]";
        public const string SpSet_ISPRechargeRocket = "[dbo].[Set_ISPRechargeRocket]";
        public const string SpSet_ISPRechargeFoster = "[dbo].[Set_ISPRechargeFoster]";
        public const string SpSet_ISPRechargeNagad = "[dbo].[Set_ISPRechargeNagad]";
        public const string SpSet_bilISPUserPaymentByInvoiceWithbKash = "[dbo].[Set_bilISPUserPaymentByInvoiceWithbKash]";
        public const string SpSet_bilISPUserPaymentByInvoiceID = "[dbo].[Set_bilISPUserPaymentByInvoiceID]";
        public const string SpSet_bilISPUserPaymentByChildInvoiceID = "[dbo].[Set_bilISPUserPaymentByChildInvoiceID]";
        public const string SpSet_accUntracedWithBkash = "[dbo].[Set_accUntracedWithBkash]";
        //public const string SpSet_bilISPUserPaymentByInvoiceWithbKashTest = "[dbo].[Set_bilISPUserPaymentByInvoiceWithbKash2]";

        //Virtual Machine
        public const string SpPut_VirtualMachineStartStop = "[dbo].[Set_bizCloudVMStartstop]";
        public const string SpSet_bizCloudVMStartStopUnmanaged = "[dbo].[Set_bizCloudVMStartstopUnmanaged]";
        public const string SpGet_CloudVMSWithPagination = "[dbo].[Get_bizCloudVMSWithPagination]";
        public const string SpGet_bizCloudVMSUnmanagedWithPagination = "[dbo].[Get_bizCloudVMSUnmanagedWithPagination]";
        public const string SpGet_CloudUserVMList = "[dbo].[Get_bizCloudUserVMList]";
        public const string SpGet_bizCloudVMsWithPaginationByUser = "[dbo].[Get_bizCloudVMsWithPaginationByUser]";
        public const string SpGet_bizCloudSubTenantVMsWithPagination = "[dbo].[Get_bizCloudSubTenantVMsWithPagination]";
        public const string SpGet_bizCloudTerminatedVMSPagination = "[dbo].[Get_bizCloudTerminatedVMSPagination]";
        public const string SpGet_bizCloudVmByUserVmId = "[dbo].[Get_bizCloudVmByUserVmId]";
        public const string SpGet_bizCloudVmNoteByVmId = "[dbo].[Get_bizCloudVmNoteByVmId]";
        public const string SpGet_cloudDeployTypeService = "[dbo].[Get_cloudDeployTypeService]";
        public const string SpGet_cloudCPUMemoryByOS = "[dbo].[Get_cloudCPUMemoryByOS]";
        public const string SpGet_cloudCPUMemoryById = "[dbo].[Get_cloudCPUMemoryById]";
        public const string SpGet_cloudHarwareCost = "[dbo].[Get_bizCloudHarwareCost]";
        public const string SpGet_bizCloudUpdateHarwareCost = "[dbo].[Get_bizCloudUpdateHarwareCost]";
        public const string SpGet_cloudPolicyCost = "[dbo].[Get_bizCloudPolicyCost]";
        public const string SpSet_cloudInstanceCost = "[dbo].[Set_cloudInstanceCost]";
        public const string SpSet_bizCloudVmDeployDraft = "[dbo].[Set_bizCloudVmDeployDraft]";
        public const string SpGet_bizCloudNICCard = "[dbo].[Get_bizCloudNICCard]";

        //bill payment Cloud
        public const string SpGet_billUserPayment = "[dbo].[Get_bilCloudUserPayment]";
        public const string SpSet_cloudUserBillPayment = "[dbo].[Set_bilCloudUserPayment]";
        public const string SpSet_cloudUserBillDeployPayment = "[dbo].[Set_bilCloudUserDeployPayment]";
        public const string SpSet_cloudUserVMBillDeployPayment = "[dbo].[Set_bilCloudUserVMDeployPayment]";
        public const string SpSet_cloudUserBillPaymentPAG = "[dbo].[Set_bilCloudUserPaymentPayGo]";
        public const string SpSet_bilCloudUserPaymentPayGoUnmanaged = "[dbo].[Set_bilCloudUserPaymentPayGoUnmanaged]";
        public const string SpGet_VirtualMachineStartStop = "[dbo].[Get_bilCloudUserExpire]";
        public const string SpGet_bilCloudUserExpireUnmanaged = "[dbo].[Get_bilCloudUserExpireUnmanaged]";
        public const string SpGet_UserWiseVirtualMachineInfo = "[dbo].[Get_bilCloudUserVMInfo]";
        public const string SpGet_bizCloudUserPolicyCharge = "[dbo].[Set_bizCloudUserPolicy]";
        public const string SpGet_bizCloudUserVmStorage = "[dbo].[Set_bizCloudUserVmStorage]";
        public const string SpGet_bizCloudUserInvoiceTotalDeduct = "[dbo].[Set_bizCloudUserInvoiceTotalDeduct]";
        public const string SpGet_PaymentHistory = "[dbo].[Get_PaymentHistory]";
        public const string SpGet_RechargeHistory = "[dbo].[Get_RechargeHistory]";
        public const string SpGet_CouponHistory = "[dbo].[Get_CouponHistory]";
        public const string SpGet_PayableByUser = "[dbo].[Get_PayableByUser]";
        public const string SpPut_bizCloudUserVmHourlyRevised = "[dbo].[Put_bizCloudUserVmHourlyRevised]";
        public const string SpPut_bizCloudUserVmHourlyRevisedUnmanaged = "[dbo].[Put_bizCloudUserVmHourlyRevisedUnmanaged]";
        public const string SpSet_bKashToken = "[dbo].[Set_bKashToken]";
        public const string SpSet_bKashMarchantInvoice = "[dbo].[Set_bKashMarchantInvoice]";

        #region bill nagad
        public const string SpSet_NagadPaymentOrder = "[dbo].[Set_NagadPaymentOrder]";
        #endregion

        // business isp
        public const string SpGet_UserIsp = "[dbo].[Get_UserIsp]";
        public const string SpGet_cmnUserIsp = "[dbo].[Get_cmnUserIsp]";
        public const string SpGet_bizIspUser = "[dbo].[Get_bizIspUser]";
        public const string SpGet_bizIspUser_New = "[dbo].[Get_bizIspUser_New]";
        public const string SpGet_bizIspUserPackServiceExport = "[dbo].[Get_bizIspUserPackServiceExport]";
        public const string SpGet_bizIspUserNoc = "[dbo].[Get_bizIspUserNoc]";
        public const string SpGet_bizIspUserDistributor = "[dbo].[Get_bizIspUserDistributor]";
        public const string SpGet_bizIspUserService = "[dbo].[Get_bizIspUserService]";
        public const string SpGet_bizISPSessionChart = "[dbo].[Get_bizISPSessionChart]";
        public const string SpGet_bizIspDataUsage = "[dbo].[Get_bizISPDataUsage]";
        public const string SpGet_bizISPDataUsageTop = "[dbo].[Get_bizISPDataUsageTop]";
        public const string SpGet_cmnIspUserWithPagination = "[dbo].[Get_cmnIspUserWithPagination]";
        public const string SpGet_IspPackService = "[dbo].[Get_IspPackService]";
        public const string SpGet_bizIspUserPackService = "[dbo].[Get_bizIspUserPackService]";
        public const string SpGet_bizIspUserExpire = "[dbo].[Get_bizIspUserExpire]";
        public const string SpSet_bizIspChangePackagePayment = "[dbo].[Set_bizIspChangePackagePayment]";
        //public const string SpSet_bizIspChangePackagePayment = "[dbo].[Set_bizIspChangePackagePayment2]";
        public const string SpSet_bilISPUserPaymentByInvoice = "[dbo].[Set_bilISPUserPaymentByInvoice]";
        public const string SpSet_bilISPUserPaymentByChildInvoice = "Set_bilISPUserPaymentByChildInvoice";
        public const string SpGet_BizIspUserPackServiceRelatedData = "[dbo].[Get_BizIspUserPackServiceRelatedData]";
        public const string SpGet_IspLeadWithPagination = "[dbo].[Get_IspLeadWithPagination]";
        public const string SpGet_IspLeadConnection = "[dbo].[Get_IspLeadConnection]";
        public const string SpGet_bizISPUserByID = "[dbo].[Get_bizISPUserByID]";
        public const string SpSet_bizIspUpdateUserPackService = "[dbo].[Set_bizIspUpdateUserPackService]";
        public const string SpSet_bizIspUserPackServiceOtc = "[dbo].[Set_bizIspUserPackServiceOtc]";

        // cloud
        public const string SpSet_bilCloudUserPaymentByInvoice = "[dbo].[Set_bilCloudUserPaymentByInvoice]";

        //Get_bizIspOfflineUser
        public const string SpGet_bizIspOfflineUser = "[dbo].[Get_bizIspOfflineUser]";
        public const string SpGet_bizISPUserPackWithPagination = "[dbo].[Get_bizISPUserPackWithPagination]";
        public const string SpGet_bizISPUserPackByID = "[dbo].[Get_bizISPUserPackByID]";
        public const string SpGet_bizISPUserConnectionByID = "[dbo].[Get_bizISPUserConnectionByID]";
        public const string SpGet_bizISPUserByUsername = "[dbo].[Get_bizISPUserByUsername]";

        // Cloud User
        public const string SpGet_cmnCloudUserWithPagination = "[dbo].[Get_cmnCloudUserWithPagination]";
        public const string SpGet_CompanyDetails = "[dbo].[Get_CompanyDetails]";

        //Cloud Sales
        public const string SpGet_CloudLeadWithPagination = "[dbo].[Get_CloudLeadWithPagination]";
        public const string SpGet_CloudLeadCommentsWithPagination = "[dbo].[Get_CloudLeadCommentWithPagination]";
        public const string Get_CloudOpportunityWithPagination = "[dbo].[Get_CloudOpportunityWithPagination]";
        public const string Get_CloudOpportunityById = "[dbo].[Get_CloudOpportunityById]";
        public const string SpGet_CloudLeadSourceWithPagination = "[dbo].[Get_CloudLeadSourceWithPagination]";
        public const string SpGet_CloudLeadReferenceWithPagination = "[dbo].[Get_CloudLeadReferenceWithPagination]";
        public const string SpGet_CloudLeadStatusWithPagination = "[dbo].[Get_CloudLeadStatusWithPagination]";
        public const string SpGet_CloudSalesPersonsList = "[dbo].[Get_CloudSalesPersonsList]";
        //Cloud Opportunity
        public const string SpGet_CloudPackService = "[dbo].[Get_CloudPackService]";
        public const string SpGet_MarketingPersonnWithPagination = "[dbo].[Get_MarketingPersonnWithPagination]";
        //Cloud Approval
        public const string SpGet_CloudApprovarPersonsList = "[dbo].[Get_CloudApprovalPersonsList]";
        public const string SpGet_CloudApprovalList = "[dbo].[Get_CloudApprovalList]";
        public const string SpGet_CloudUserOfferApprovalList = "[dbo].[Get_CloudUserOfferApprovalList]";
        public const string SpGet_CloudApprovalHistoryList = "[dbo].[Get_CloudApprovalHistoryList]";
        public const string SpGet_CloudSalesTeam = "[dbo].[Get_CloudSalesTeam]";
        //bill payment ISP
        public const string SpGet_billISPUserPayment = "[dbo].[Get_bilISPUserPayment]";
        public const string SpGet_billISPUserExpire = "[dbo].[Get_bilISPUserExpire]";
        public const string SpGet_billISPUserExpireNew = "[dbo].[Get_bilISPUserExpireNew]";
        public const string SpGet_billISPUserExpireNewAfter = "[dbo].[Get_bilISPUserExpireNewAfter]";
        public const string SpGet_billISPPackServiceLastPayEnd = "[dbo].[Get_billISPPackServiceLastPayEnd]";
        public const string SpSet_ispUserBillPayment = "[dbo].[Set_bilISPUserPayment]";
        public const string SpSet_ispUserBillPaymentOnly = "[dbo].[Set_bilISPUserPaymentOnly]";
        public const string SpSet_bilISPUserInvoiceAndPayment = "[dbo].[Set_bilISPUserInvoiceAndPayment]";
        public const string SpSet_bilISPUserBackBalance = "[dbo].[Set_bilISPUserBackBalance]";
        public const string SpGet_ISPPaymentHistory = "[dbo].[Get_ISPPaymentHistory]";
        public const string SpGet_ISPRechargeHistory = "[dbo].[Get_ISPRechargeHistory]";
        public const string SpGet_ISPTransactionHistory = "[dbo].[Get_ISPTransactionHistory]";
        public const string SpSet_ISPPendingInvoiceTransaction = "[dbo].[Set_ISPPendingInvoiceTransaction]";
        //Set_CloudPendingInvoiceTran
        //Cloud
        public const string SpSet_CloudPendingInvoiceTran = "[dbo].[Set_CloudPendingInvoiceTran]";

        //ISP Invoice
        public const string SpGet_bilISPInvoice = "[dbo].[Get_bilISPInvoice]";
        public const string SpSet_bilISPInvoice = "[dbo].[Set_bilISPInvoice]";
        public const string SpSet_bilISPInvoiceNew = "[dbo].[Set_bilISPInvoiceNew]";
        public const string SpGet_bilIspInvoiceNo = "[dbo].[Get_bilIspInvoiceNo]";

        public const string SpGet_bilIspInvByIspUsrId = "[dbo].[Get_bilIspInvoiceByIspUserId]";
        public const string SpGet_bilIspInvDetailBycldUsrId = "[dbo].[Get_bilIspInvoiceDetailsByCloudUserId]";
        public const string SpGet_bilIspChildInvDetailByInvoiceID = "[dbo].[Get_bilIspChildInvoiceDetail]";
        public const string SpGet_bilIspChildInvDetailOfIPTSPByInvoiceID = "[dbo].[Get_bilIspChildInvoiceDetailOfIPTSP]";
        public const string SpGet_bilIspInvDetailByInvoiceID = "[dbo].[Set_bilIspInvoiceDetail]";
        public const string SpGet_bilIspInvDetailOfIPTSPByInvoiceID = "[dbo].[Set_bilIspInvoiceDetailOfIPTSP]";
        public const string SpGet_bizIptspNumberWithPagination = "[dbo].[Get_bizIptspNumberWithPagination]";
        public const string SpGet_bizIptspRechargeNumberWithPagination = "[dbo].[Get_bizIptspRechargeNumberWithPagination]";
        public const string SpSet_UserPackServiceNewCycle = "[dbo].[Set_UserPackServiceNewCycle]";
        //public const string SpGet_bilCldInvDetailMoreByUserVMId = "[dbo].[Get_bilCloudInvoiceMoreDetail]";

        public const string SpUpdate_bilIspInvoiceDetail = "[dbo].[Update_billIspInvoiceDetail]";

        //Voucher
        public const string SpSet_accLedger = "[dbo].[Set_accLedger]";
        public const string SpGet_GeneratedVoucherNo = "[dbo].[Get_accGeneratedVoucherNo]";
        public const string SpSet_VoucherMaster = "[dbo].[Set_accVoucherMaster]";
        public const string SpSet_VoucherDetail = "[dbo].[Set_accVoucherDetail]";
        public const string SpGet_accLedgerSearchByVoucherType = "[dbo].[Get_accLedgerSearchByVoucherType]";
        public const string SpSet_accVoucherApprove = "[dbo].[Set_accVoucherApprove]";
        public const string SpGet_accVouchersWithPagination = "[dbo].[Get_accVouchersWithPagination]";
        public const string SpGet_Get_accVoucherRepor = "[dbo].[Get_accVoucherReport]";

        //Ledger
        public const string SpGet_accLedgersWithPagination = "[dbo].[Get_accLedgersWithPagination]";
        public const string SpGet_GeneratedLedgerNo = "[dbo].[Get_accGeneratedLedgerNo]";



        //Acc Report
        public const string SpGet_accChartAccount = "[dbo].[Get_accChartAccount]";
        public const string SpGet_accIncomeStatement = "[dbo].[Get_accIncomeStatement]";
        public const string SpRptGet_accIncomeStatement = "[dbo].[rptGet_accIncomeStatement]";
        public const string SpGet_accReceiptPayment = "[dbo].[Get_accReceiptPayment]";
        public const string SpRptGet_accReceiptPayment = "[dbo].[rptGet_accReceiptPayment]";
        public const string SpGet_accBalanceSheet = "[dbo].[Get_accBalanceSheet]";
        public const string SpRptGet_accBalanceSheet = "[dbo].[rptGet_accBalanceSheet]";
        public const string SpGet_accLedgerBook = "[dbo].[Get_accLedgerBook]";
        public const string SpGet_accLedgerBookDetail = "[dbo].[Get_accLedgerBookDetail]";
        public const string SpGet_accTrialBalance = "[dbo].[Get_accTrialBalance]";
        public const string SpGet_accAccountHeadSerial = "[dbo].[Get_accAccountHeadSerial]";
        public const string SpGet_accAccountProfitLoss = "[dbo].[Get_accAccountStatementProfitLoss]";
        public const string SpGet_accAccountBalanceSheet = "[dbo].[Get_accAccountBalanceSheet]";
        public const string SpGet_accCashBook = "[dbo].[Get_accCashBook]";
        public const string SpGet_accChangesInEquity = "[dbo].[Get_accChangesInEquity]";
        public const string SprptGet_accChartAccount = "[dbo].[rptGet_accChartAccount]";
        public const string SpRptGet_accCashBook = "[dbo].[rptGet_accCashBook]";
        public const string SpGet_bilISPPaymentDetailByDate = "[dbo].[Get_bilISPPaymentDetailByDate]";
        public const string SpGet_bilIspPaymentMethod = "[dbo].[Get_bilIspPaymentMethod]";
        public const string SpGet_bilISPInvoiceParent = "[dbo].[Get_bilISPInvoiceParent]";
        public const string SpGet_bilISPInvoiceDetail = "[dbo].[Get_bilISPInvoiceDetail]";
        // cloud
        public const string SpGet_bilCloudInvoicePay = "[dbo].[Get_bilCloudInvoicePay]";
        public const string SpGet_bilCloudPaymentDetailByDate = "[dbo].[Get_bilCloudPaymentDetailByDate]";
        public const string SpGet_bilCloudInvoiceDetail = "[dbo].[Get_bilCloudInvoiceDetail]";
        //

        //Cloud Bundle
        public const string SpGet_bizCloudBundleWithPagination = "[dbo].[Get_bizCloudBundleWithPagination]";

        //Cloud Environment
        public const string SpGet_bizCloudEnvironmentWithPagination = "[dbo].[Get_bizCloudEnvironmentWithPagination]";
        //Cloud services
        public const string SpGet_bizCloudServicesWithPagination = "[dbo].[Get_bizCloudServicesWithPagination]";
        //Cloud Custom services
        public const string SpGet_bizCloudCustomServicesWithPagination = "[dbo].[Get_bizCloudCustomServicesWithPagination]";
        //cloud policy
        public const string SpGet_bizCloudPolicyWithPagination = "[dbo].[Get_bizCloudPolicyWithPagination]";
        //Cloud Price Plan
        public const string SpGet_bizCloudCPUCost = "[dbo].[Get_bizCloudCPUCost]";
        public const string SpGet_bizCloudMemoryCost = "[dbo].[Get_bizCloudMemoryCost]";
        public const string SpGet_bizCloudStorageCost = "[dbo].[Get_bizCloudStorageCost]";
        public const string SpGet_bizCloudStorageSizeCost = "[dbo].[Get_bizCloudStorageSizeCost]";
        public const string SpGet_bizCloudPolicyCost = "[dbo].[Get_bizCloudPolicyCost]";
        public const string SpGet_bizCloudServiceTypeCost = "[dbo].[Get_bizCloudServiceTypeCost]";
        public const string SpGet_bizCloudServiceCost = "[dbo].[Get_bizCloudServiceCost]";
        public const string SpGet_bizCloudNICCost = "[dbo].[Get_bizCloudNICCost]";
        public const string SpGet_bizCloudNIC2Cost = "[dbo].[Get_bizCloudNIC2Cost]";
        public const string SpGet_bizCloudInstanceOTC = "[dbo].[Get_bizCloudInstanceOTC]";

        //Cloud Instance
        public const string SpGet_bizCloudInstanceWithPagination = "[dbo].[Get_bizCloudInstanceWithPagination]";


        //CRM Cloud User Tickets realted
        public const string SpGet_crmCloudTicket = "[dbo].[Get_crmCloudTicket]";
        public const string SpGet_crmCloudTicketByCloudUserId = "[dbo].[Get_crmCloudTicketByCloudUserId]";

        //CRM ISP User Tickets realted
        public const string SpGet_crmIspTicket = "[dbo].[Get_crmIspTicket]";
        public const string SpGet_crmIspTicketByCloudUserId = "[dbo].[Get_crmIspTicketByIspUserId]";
        public const string SpGet_crmIspSupportTicket = "[dbo].[Get_SupportTicketWithPagination]";
        public const string SpGet_crmIspNewSupportTicket = "[dbo].[Get_SupportNewTicketWithPagination]";

        //Hrm related
        public const string SpGet_hrmAttendance = "[dbo].[Get_hrmAttendance]";
        public const string SpGet_hrmAttendanceSync = "[dbo].[Get_hrmAttendanceSync]";
        public const string SpGet_hrmExtendedEmployees = "[dbo].[Get_hrmExtendedEmployees]";
        public const string SpGet_hrmExtendedEmployeeById = "[dbo].[Get_hrmExtendedEmployeeById]";
        public const string SpGet_hrmAttendanceUserLogin = "[dbo].[Get_hrmAttendanceUserLogin]";
        public const string SpGet_CmnSMSWithPagination = "[dbo].[Get_CmnSMSWithPagination]";
        public const string SpGet_leaveBalanceWithPagination = "[dbo].[Get_leaveBalanceWithPagination]";
        public const string SpGet_hrmProcessedData = "[dbo].[Get_hrmProcessedData]";
        public const string SpGet_hrmEmployeeWithPagination = "[dbo].[Get_hrmEmployeeWithPagination]";
        public const string SpSet_hrmAttProcessedWithAttFix = "[dbo].[Set_hrmAttProcessedWithAttFix]";
        public const string SpGet_LeaveBalance = "[dbo].[Get_LeaveBalance]";
        public const string SpGet_LeaveBalanceByEmp = "[dbo].[Get_LeaveBalanceByEmp]";
        public const string SpSet_hrmLeaveEntry = "[dbo].[Set_hrmLeaveEntry]";
        public const string SpGet_hrmLeaveEntry = "[dbo].[Get_hrmLeaveEntry]";
        public const string SpGet_hrmLeaveEntryNotify = "[dbo].[Get_hrmLeaveEntryNotify]";
        public const string SpSet_hrmLeaveApprove = "[dbo].[Set_hrmLeaveApprove]";
        public const string SpGet_EmployeeForLeave = "[dbo].[Get_EmployeeForLeave]";

        //Processflow
        public const string SpGet_ProcessFlowByID = "[dbo].[Get_ProcessFlowByID]";

        //Sales & Marketing
        public const string SpGet_bizIspOpportunityPackService = "[dbo].[Get_bizIspOpportunityPackService]";
        public const string SpGet_bizIspLeadPackService = "[dbo].[Get_bizIspLeadPackService]";
        public const string SpGet_salIspAccount = "[dbo].[Get_salIspAccount]";
        public const string SpGet_SalIspOpportunityWithPage = "[dbo].[Get_SalIspOpportunityWithPage]";
        public const string SpGet_bizIspOpportunityPackServiceByOpptConnID = "[dbo].[Get_bizIspOpportunityPackServiceByOpptConnId]";
        public const string SpGet_cmnNOCMenuPermission = "[dbo].[Get_cmnNOCMenuPermission]";
        public const string SpGet_BillCollector = "[dbo].[Get_BillCollector]";

        //BK notification
        public const string SpGet_bkashNotificationWithPagination = "[dbo].[Get_bkashNotificationWithPagination]";
        public const string SpGet_bKashWebHookLogWithPage = "[dbo].[Get_bKashWebHookLogWithPage]";
        public const string SpGet_bkashNotificationWithPaginationNoc = "[dbo].[Get_bkashNotificationWithPaginationNoc]";
        public const string SpGet_NotificationIspUserWithPagination = "[dbo].[Get_NotificationIspUserWithPagination]";
        public const string SpGet_bilBKashPaymentPortalTransactionWithPagination = "[dbo].[Get_bilBKashPaymentPortalTransactionWithPagination]";
        public const string SpGet_bilFosterPaymentPortalTransactionWithPagination = "[dbo].[Get_bilFosterPaymentPortalTransactionWithPagination]";
        //SpGet_fiberNetworkWithPagination
        public const string SpGet_fiberNetworkWithPagination = "[dbo].[Get_fiberNetworkWithPagination]";
        public const string SpUpdate_bizIspFiberNetworkSM = "[dbo].[Update_bizIspFiberNetworkSM]";
        //SpGet_areaWithPagination
        public const string SpGet_areaWithPagination = "[dbo].[Get_areaWithPagination]";
        // Get_CloudAreaWithPage
        public const string SpGet_CloudAreaWithPage = "[dbo].[Get_CloudAreaWithPage]";

        #region contact us
        public const string SpGet_ContactUsWithPagination = "[dbo].[Get_ContactUsWithPagination]";
        #endregion

        //Payment Gateway
        public const string SpGet_NagadClientVarification = "[dbo].[Get_NagadClientVarification]";
        public const string SpGet_NagadClientConfirmation = "[dbo].[Get_NagadClientConfirmation]";
        public const string SpGet_NagadClientStatusCheck = "[dbo].[Get_NagadClientStatusCheck]";
        //Payment Gateway

        #region Oracle
        #region Users
        public const string SpGETORA_CMNUSER = "JTEST.GETORA_CMNUSER";
        public const string Ora_SpGet_UserByCompany = "USERROLESETUP.Get_UserByCompany";
        #endregion Users
        #region Menu
        //Oracle Menu
        public const string Ora_SpGet_Menu_By_RoleID = "MENUSETUP.Get_Menu_By_RoleID";
        public const string Ora_SpGET_CmnMenu = "MENUSETUP.Get_CmnMenu";
        public const string Ora_SpGet_UserRoleByPage = "USERROLESETUP.Get_UserRoleByPage";
        //public const string Ora_SpGet_UserRoleById = "USERROLESETUP.Get_UserRoleById";
        #endregion Menu
        #region seperate side menu
        public const string Ora_SpGET_MainMenu = "MENUSETUP.Get_CmnMainMenu";
        public const string Ora_SpGET_ChildMenu = "MENUSETUP.Get_CmnChildMenu";
        public const string Ora_SpGET_SubChildMenu = "MENUSETUP.Get_CmnSubChildMenu";
        #endregion
        #region customer
        public const string Ora_SpGet_CustomerByPage = "CUSTOMERSETUP.Get_CustomerByPage";
        public const string Ora_SpGet_CustomerById = "CUSTOMERSETUP.Get_CustomerByID";
        #endregion

        #region Client
        public const string Ora_SpGet_ClientByPage = "CLIENTSETUP.Get_ClientByPage";
        public const string Ora_SpSet_Client = "CLIENTSETUP.Set_Client";
        public const string Ora_SpGet_ClientById = "CLIENTSETUP.Get_ClientByID";
        #endregion


        #region Register
        public const string Ora_SpSet_Register = "REGISTERSETUP.Set_Register";
        #endregion

        #region Client Bank
        public const string Ora_SpGet_ClientBankByPage = "CLIENTBANK.Get_ClientBankByPage";
        public const string Ora_SpSet_ClientBank = "CLIENTBANK.Set_ClientBank";
        public const string Ora_SpGet_ClientBankById = "CLIENTBANK.Get_ClientBankByID";
        #endregion

        #region Client Type
        public const string Ora_SpGet_ClientTypeByPage = "CLIENTTYPESETUP.Get_ClientTypeByPage";
        public const string Ora_SpSet_ClientType = "CLIENTTYPESETUP.Set_ClientType";
        public const string Ora_SpGet_ClientTypeById = "CLIENTTYPESETUP.Get_ClientTypeByID";
        #endregion

        #region Business Category
        public const string Ora_SpGet_CategoryByPage = "BUSINESSCATEGORYSETUP.Get_CategoryByPage";
        public const string Ora_SpSet_Category = "BUSINESSCATEGORYSETUP.Set_Category";
        public const string Ora_SpGet_CategoryById = "BUSINESSCATEGORYSETUP.Get_CategoryByID";
        #endregion

        #region Business Brand
        public const string Ora_SpGet_BrandByPage = "BUSINESSBRANDSETUP.Get_BrandByPage";
        public const string Ora_SpSet_Brand = "BUSINESSBRANDSETUP.Set_Brand";
        public const string Ora_SpGet_BrandById = "BUSINESSBRANDSETUP.Get_BrandByID";
        #endregion

        #region Business Platform
        public const string Ora_SpGet_BPlatformByPage = "BUSINESSPLATFORMSETUP.Get_BPlatformByPage";
        public const string Ora_SpSet_BPlatform = "BUSINESSPLATFORMSETUP.Set_BPlatform";
        public const string Ora_SpGet_BPlatformById = "BUSINESSPLATFORMSETUP.Get_BPlatformById";
        #endregion

        #region Business Parameter
        public const string Ora_SpGet_BParameterByPage = "BUSINESSPARAMETERSETUP.Get_BParameterByPage";
        public const string Ora_SpSet_BParameter = "BUSINESSPARAMETERSETUP.Set_BParameter";
        public const string Ora_SpGet_BParameterById = "BUSINESSPARAMETERSETUP.Get_BParameterById";
        #endregion

        #region Business Parameter Task
        public const string Ora_SpGet_BParameterTaskByPage = "BUSINESSPARAMETERTASKSETUP.Get_BParameterTaskByPage";
        public const string Ora_SpSet_BParameterTask = "BUSINESSPARAMETERTASKSETUP.Set_BParameterTask";
        public const string Ora_SpGet_BParameterTaskById = "BUSINESSPARAMETERTASKSETUP.Get_BParameterTaskById";
        #endregion

        #region Business Metrics
        public const string Ora_SpGet_BMetricsByPage = "BUSINESSMETRICSSETUP.Get_BMetricsByPage";
        public const string Ora_SpSet_BMetrics = "BUSINESSMETRICSSETUP.Set_BMetrics";
        public const string Ora_SpGet_BMetricsById = "BUSINESSMETRICSSETUP.Get_BMetricsById";
        #endregion

        #region Business Asset Type
        public const string Ora_SpGet_BAssetTypeByPage = "BUSINESSASSETTYPESETUP.Get_BAssetTypeByPage";
        public const string Ora_SpSet_BAssetType = "BUSINESSASSETTYPESETUP.Set_BAssetType";
        public const string Ora_SpGet_BAssetTypeById = "BUSINESSASSETTYPESETUP.Get_BAssetTypeById";
        #endregion

        #region Business Publisher
        public const string Ora_SpGet_BPublisherByPage = "BUSINESSPUBLISHERSETUP.Get_BPublisherByPage";
        public const string Ora_SpSet_BPublisher = "BUSINESSPUBLISHERSETUP.Set_BPublisher";
        public const string Ora_SpGet_BPublisherById = "BUSINESSPUBLISHERSETUP.Get_BPublisherById";
        #endregion

        #region Business Supplements
        public const string Ora_SpGet_BSupplementsByPage = "BUSINESSSUPPLEMENTSSETUP.Get_BSupplementsByPage";
        public const string Ora_SpSet_BSupplements = "BUSINESSSUPPLEMENTSSETUP.Set_BSupplements";
        public const string Ora_SpGet_BSupplementsById = "BUSINESSSUPPLEMENTSSETUP.Get_BSupplementsById";
        #endregion

        #region Business Media Broadcast
        public const string Ora_SpGet_BroadcastByPage = "BUSINESSBROADCASTSETUP.Get_BroadcastByPage";
        public const string Ora_SpSet_Broadcast = "BUSINESSBROADCASTSETUP.Set_Broadcast";
        public const string Ora_SpGet_BroadcastById = "BUSINESSBROADCASTSETUP.Get_BroadcastById";
        #endregion

        #region Business Media Program
        public const string Ora_SpGet_ProgramByPage = "BUSINESSPROGRAMSETUP.Get_ProgramByPage";
        public const string Ora_SpSet_Program = "BUSINESSPROGRAMSETUP.Set_Program";
        public const string Ora_SpGet_ProgramById = "BUSINESSPROGRAMSETUP.Get_ProgramById";
        #endregion

        #region Business Media Genre        
        public const string Ora_SpSet_Dropdown_Genre = "BUSINESSDROPDOWNSETUP.Set_Dropdown_Genre";
        #endregion

        #region Service Head Group
        public const string Ora_SpGet_ServiceHeadGroupByPage = "SERVICEHEADGROUPSETUP.Get_ServiceHeadGroupByPage";
        public const string Ora_SpSet_ServiceHeadGroup = "SERVICEHEADGROUPSETUP.Set_ServiceHeadGroup";
        public const string Ora_SpGet_ServiceHeadGroupById = "SERVICEHEADGROUPSETUP.Get_ServiceHeadGroupById";
        #endregion

        #region Service Head
        public const string Ora_SpGet_ServiceHeadByPage = "SERVICEHEADSETUP.Get_ServiceHeadByPage";
        public const string Ora_SpSet_ServiceHead = "SERVICEHEADSETUP.Set_ServiceHead";
        public const string Ora_SpGet_ServiceHeadById = "SERVICEHEADSETUP.Get_ServiceHeadById";
        public const string Ora_SpGet_SrvHeadByHeadGroupAndCategoryId = "SERVICEHEADSETUP.Get_SrvHeadByHeadGroupAndCategoryId";
        #endregion

        #region Quotation
        public const string Ora_SpGet_QuotationRefNo = "QUOTATIONSETUP.Get_QuotationReferenceNo";
        public const string Ora_SpGet_QuotationByPage = "QUOTATIONSETUP.Get_QuotationByPage";
        public const string Ora_SpGet_QuotationById = "QUOTATIONSETUP.Get_QuotationById";
        public const string Ora_SpGet_QuotationMasterById = "QUOTATIONSETUP.Get_QuotationMasterById";
        public const string Ora_SpGet_QuotationDetailById = "QUOTATIONSETUP.Get_QuotationDetailById";
        public const string Ora_SpGet_QuotationDetailMediaById = "QUOTATIONSETUP.Get_QuotationDetailMediaById";
        public const string Ora_SpGet_QuotationDetailPrintById = "QUOTATIONSETUP.Get_QuotationDetailPrintById";
        public const string Ora_SpGet_QuotationDetailBuyingById = "QUOTATIONSETUP.Get_QuotationDetailBuyingById";
        public const string Ora_SpGet_QuotById = "QUOTATIONSETUP.Get_QuotById";
        public const string Ora_SpSet_QuotationDetail = "QUOTATIONSETUP.Set_QuotationDetail";
        public const string Ora_SpSet_QuotationMaster = "QUOTATIONSETUP.Set_QuotationMaster";
        public const string Ora_SpSet_QuotationMasterDetail = "QUOTATIONSETUP.Set_QuotationMasterDetail";
        public const string Ora_SpSet_QuotationDetail_Common = "QUOTATIONSETUP.Set_QuotationDetail_Common";
        public const string Ora_SpSet_QuotationMasterDetail_Media = "QUOTATIONSETUP.Set_QuotationMasterDetail_Media";
        public const string Ora_SpSet_QuotationMasterDetail_Print = "QUOTATIONSETUP.Set_QuotationMasterDetail_Print";
        public const string Ora_SpSet_QuotationMasterDetail_Buying = "QUOTATIONSETUP.Set_QuotationMasterDetail_Buying";
        public const string Ora_SpGet_QuotationTermsConditionById = "QUOTATIONSETUP.Get_QuotationTermsConditionById";
        #endregion

        #region new Quotation
        public const string Ora_SpGet_QuotationsRefNo = "QUOTATIONSETUPS.Get_QuotationReferenceNo";
        public const string Ora_SpGet_QuotationsByPage = "QUOTATIONSETUPS.Get_QuotationByPage";
        ///public const string Ora_SpGet_QuotationsById = "QUOTATIONSETUPS.Get_QuotationById";
        public const string Ora_SpGet_QuotationsMasterById = "QUOTATIONSETUPS.Get_QuotationMasterById";
        public const string Ora_SpGet_QuotationsDetailById = "QUOTATIONSETUPS.Get_QuotationDetailById";
        public const string Ora_SpGet_QuotsById = "QUOTATIONSETUPS.Get_QuotById";
        public const string Ora_SpSet_QuotationsDetail = "QUOTATIONSETUPS.Set_QuotationDetail";
        public const string Ora_SpSet_QuotationsMaster = "QUOTATIONSETUPS.Set_QuotationMaster";
        public const string Ora_SpSet_QuotationsDetail_Common = "QUOTATIONSETUPS.Set_QuotationDetail_Common";
        public const string Ora_SpGet_QuotationsTermsConditionById = "QUOTATIONSETUPS.Get_QuotationTermsConditionById";
        #endregion

        #region
        public const string Ora_SpSet_requirementMaster = "PKG_APPLICANT_REQUIREMENT.Set_APPLICANT_MASTAR";
        public const string Ora_SpGet_TESTByPage = "PKG_APPLICANT_REQUIREMENT.Get_APPLICANT_BY_PAGE";

        #endregion
        #region ReqForm
        public const string Ora_SpSet_ApplicantFormMaster = "PKG_APPLICANT_REQUIREMENT.Set_APPLICANT_MASTAR";
        public const string Ora_SpSet_ApplicantFormAcademicQlf = "PKG_APPLICANT_REQUIREMENT.Set_APPLICANT_ACC_QLF";
        public const string Ora_SpSet_ApplicantFormWorkExp = "PKG_APPLICANT_REQUIREMENT.Set_APPLICANT_WRK_EXP";
        #endregion

        #region WorkOrder
        //public const string Ora_SpSet_QWorkOrderDetail = "WORKORDERSETUP.Set_QuotationDetail";
        public const string Ora_SpGet_WorkorderFreeQuot = "WORKORDERSETUP.Get_LeftQuotByWorkOrderByPage";
        public const string Ora_SpGet_WorkOrderRefNo = "WORKORDERSETUP.Get_WOrkOrderReferenceNo";
        public const string Ora_SpGet_WorkOrderByPage = "WORKORDERSETUP.Get_WorkOrderByPage";
        public const string Ora_SpGet_WorkOrderMasterById = "WORKORDERSETUP.Get_WorkOrderMasterById";
        public const string Ora_SpGet_WorkOrderDetailById = "WORKORDERSETUP.Get_WorkOrderDetailById";
        public const string Ora_SpGet_WorkOrderDetailMediaById = "WORKORDERSETUP.Get_WorkOrderDetailMediaById";
        public const string Ora_SpGet_WorkOrderDetailPrintById = "WORKORDERSETUP.Get_WorkOrderDetailPrintById";
        public const string Ora_SpGet_WorkOrderDetailBuyingById = "WORKORDERSETUP.Get_WorkOrderDetailBuyingById";
        public const string Ora_SpSet_WorkOrderMaster = "WORKORDERSETUP.Set_WorkOrderMaster";
        public const string Ora_SpSet_WorkOrderMasterDetail = "WORKORDERSETUP.Set_WorkOrderMasterDetail";
        public const string Ora_SpSet_WorkOrderDetail_Common = "WORKORDERSETUP.Set_WorkOrderDetail_Common";
        public const string Ora_SpSet_WorkOrderMasterDetail_Media = "WORKORDERSETUP.Set_WorkOrderMasterDetail_Media";
        public const string Ora_SpSet_WorkOrderMasterDetail_Print = "WORKORDERSETUP.Set_WorkOrderMasterDetail_Print";
        public const string Ora_SpSet_WorkOrderMasterDetail_Buying = "WORKORDERSETUP.Set_WorkOrderMasterDetail_Buying";
        public const string Ora_SpGet_WorkOrderTermsConditionById = "WORKORDERSETUP.Get_WorkOrderTermsConditionById";
        public const string Ora_SpGet_ProcessFlowById = "WORKORDERSETUP.Get_ProcessFlowDetailByWorkOrderCatID";
        #endregion

        #region Common Package
        public const string Ora_SpGet_CompanyUser = "COMMONPACKAGE.Get_UserByCompany";
        public const string Ora_SpGet_AllBank = "SETTINGS.Get_AllBank";
        public const string Ora_SpGet_AllAccountType = "SETTINGS.Get_AllAccountType";
        #endregion

        #region Process Flow
        public const string Ora_SpGet_ProcessFlowByPage = "PROCESSFLOWSETUP.Get_ProcessFlowByPage";
        public const string Ora_SpGet_ProcessFlowByID = "PROCESSFLOWSETUP.Get_ProcessFlowByID";
        public const string Ora_SpGet_ProcessFlowDetailByID = "PROCESSFLOWSETUP.Get_ProcessFlowDetailByID";
        public const string Ora_SpGet_ProcessFlowDetailByCategoryID = "PROCESSFLOWSETUP.Get_ProcessFlowDetailByCategoryID";
        public const string Ora_SpGet_ProcessFlowDetailByQuotCatID = "QUOTATIONSETUP.Get_ProcessFlowDetailByQuotCatID";
        public const string Ora_SpSet_ProcessFlowMasterDetail = "PROCESSFLOWSETUP.Set_ProcessFlow";
        public const string Ora_SpGet_CommentsByID = "PROCESSFLOWSETUP.Get_CommentsByID";
        public const string Ora_SpGet_CommentsByLoggedUser = "PROCESSFLOWSETUP.Get_CommentsByUser";
        #endregion

        #endregion Oracle
    }
}
