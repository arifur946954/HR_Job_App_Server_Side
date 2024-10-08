using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmCmnParameters
    {
        #region Common prop
        public int? pageNumber { get; set; }
        public int? pageSize { get; set; }
        public bool IsPaging { get; set; }
        public bool isHeaderInEveryPage { get; set; } = false;
        public bool isFooterInEveryPage { get; set; } = false;
        public bool isHeaderInFirstPage { get; set; } = false;
        public bool isFooterInLastPage { get; set; } = false;
        public int id { get; set; }
        public int? connectionTypeId { get; set; }
        public int? purposeTypeId { get; set; }
        public int? invId { get; set; }
        public string Name { get; set; }
        public int? ModuleID { get; set; }
        public int? MenuID { get; set; }
        public string userPass { get; set; }
        public string macAddress { get; set; }
        public int rating { get; set; }
        public string userName { get; set; }
        public string tablename { get; set; }
        public string property { get; set; }
        public string policyTypeId { get; set; }
        public string values { get; set; }
        public int? CompanyID { get; set; }
        public int? CountryId { get; set; }
        public int? ServiceId { get; set; }
        public int? CloudId { get; set; }
        public int cloudMachineId { get; set; }
        public int? UserID { get; set; }
        public int? LoggedUserID { get; set; }
        public int? month { get; set; }
        public int? VmNo { get; set; }
        public int? VmId { get; set; }
        public int? cpu { get; set; }
        public string comments { get; set; }
        public int? memory { get; set; }
        public int? GroupID { get; set; }
        public int? RoleID { get; set; }
        public string RoleIDs { get; set; }
        public int? TypeID { get; set; }
        public string ClientIP { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLoggedIn { get; set; }
        public string Path { get; set; }
        public bool IsTrue { get; set; }
        public bool IsManaged { get; set; }
        public string leadBy { get; set; }
        public DateTime? SDate { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? CDate { get; set; }
        public string MailSubject { get; set; }
        public string MailTitle { get; set; }
        public int? TenantId { get; set; }
        public int? PreviousPolicyId { get; set; }
        public int? DeploymentId { get; set; }
        public int? PlanId { get; set; }
        public int? StorageId { get; set; }
        public int? ApprovedNum { get; set; }
        public string vmaction { get; set; }
        public bool Enabled { get; set; }
        public string parentTenantName { get; set; }
        public string parentTenantPassword { get; set; }
        public string Note { get; set; }
        public DateTime? Today { get; set; }
        public int? userType { get; set; }
        public bool tenantAdmin { get; set; }
        public int subTenantUserId { get; set; }
        public string currentColumn { get; set; }
        public string currentSort { get; set; }
        public string authToken { get; set; }
        public string currency { get; set; }
        public string mrcntNumber { get; set; }
        public string paymentID { get; set; }
        public int? MonthId { get; set; }
        public int? YearId { get; set; }
        public bool? canDeploy { get; set; }
        public bool? canModify { get; set; }
        public bool? isIptspPayment { get; set; }
        public int? userStatus { get; set; }
        public string Status { get; set; }
        public decimal? userPrice { get; set; }
        public int? connectionid { get; set; }
        public int? processcid { get; set; }
        public int? accountid { get; set; }
        public int? userPackServiceId { get; set; }
        public int? packServiceId { get; set; }
        public int? parentPackServiceId { get; set; }
        public long? LeadId { get; set; }
        public int? OpportunityId { get; set; }
        public int? accountId { get; set; }
        public int? contactId { get; set; }
        public int? connectionNo { get; set; }
        public List<AdvanceFilter> advanceFilters { get; set; }
        public List<int> ids { get; set; }
        public string filters { get; set; }
        public bool IsEdit { get; set; }
        public bool IsInProcess { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsUnsuccessFull { get; set; }
        public bool IsReopen { get; set; }
        public string strYear { get; set; }
        public string strMonth { get; set; }
        public List<invoiceList> invoiceList { get; set; }
        public bool isMultipleInvoicePayment { get; set; }
        public bool isHour { get; set; }
        public int dayHourNumber { get; set; }
        public List<vmLists> vmLists { get; set; }
        public int CloudApprovalId { get; set; }
        #endregion

        #region Company Business
        public int? BusinessID { get; set; }
        public decimal? CostPerHour { get; set; }
        public decimal? CostOnetime { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DueAmount { get; set; }

        #endregion

        #region Accounting
        public int GroupHeadID { get; set; }
        public string GroupName { get; set; }
        public int LedgerID { get; set; }
        public string LedgerCode { get; set; }
        #endregion

        #region types
        public string type { get; set; }
        public string subType { get; set; }
        #endregion

        #region Cloud Usage plan
        //public int CloudUsagePlanID { get; set; }
       
        #endregion

        #region cloud plan
        public int cloudPlanId { get; set; }
        #endregion

        #region Activation Profile
        //public int CloudActivationProfileID { get; set; }
        #endregion

        #region IPTV
        public int Vidid { get; set; }
        public int Catid { get; set; }
        public int subCatid { get; set; }
        public int ProgramId { get; set; }
        #endregion

        #region VM Checking
        public string appId { get; set; }
        public string prevAppId { get; set; }
        public string regionId { get; set; }
        public string memoryname { get; set; }
        public string version { get; set; }
        public string jobId { get; set; }
        public string nics { get; set; }
        public string remoteAccessType { get; set; }
        public string cloudAccountId { get; set; }
        public int? NodeQty { get; set; }
        public bool isTrial { get; set; }
        public string ParentJobName { get; set; }
        public string parentJobStatus { get; set; }
        #endregion

        #region HRM
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public int DesignationID { get; set; }
        public int DeviceID { get; set; }
        public int InOutID { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? AtnFromDate { get; set; }
        public DateTime? AtnToDate { get; set; }
        public string SrarchKey { get; set; }
        #endregion

        #region Bill Cloud Invocie
        public int? CloudUserID { get; set; }
        public int? InvoiceId { get; set; }
        #endregion

        #region Bill IPS Invocie
        public int? IspUserID { get; set; }
        public int? invoiceStatus { get; set; }
        public decimal? InvoiceTotal { get; set; }
        #endregion

        #region Cloud CRM
        public int CloudTicketCategoryId { get; set; }
        public int CloudTicketId { get; set; }
        public bool submitAsComplete { get; set; }  
        public int? leadStutusId { get; set; }
        #endregion

        #region ISP contact us
        // public string name { get; set; }
        public string email { get; set; }     
        public string phone { get; set; }
        public string message { get; set; }
        #endregion

        #region Billing ISP  
        public decimal rechargeAmount { get; set; }
        public decimal deductedAmount { get; set; }
        public bool isChildInvoicePayment { get; set; }
        #endregion

        #region Email Verification
        public string activationtoken { get; set; }
        #endregion

        public string statusCheckUrl { get; set; }

        #region Business ISP
        public int? topNumber { get; set; }
        public int? zoneId { get; set; }
        public int? areaId { get; set; }
        public string serviceStatus { get; set; }
        #endregion

        public string MenuPath { get; set; }

        #region Sales & Marketing ISP
        public string code { get; set; }
        public int? BilCollectedBy { get; set; }
        public int? statusValue { get; set; }
        #endregion

        #region otp
        public string TwoWayFactor { get; set; }
        public string Otp { get; set; }
        #endregion
    }

    public class AdvanceFilter
    {
        public string column { get; set; }
        public string operators { get; set; }
        public string value { get; set; }
    }
    public class invoiceList
    {
        public int? ispInvoiceId { get; set; }
        public string invoiceNo { get; set; }
        public string genMonth { get; set; }
        public DateTime invoiceDate { get; set; }
        public DateTime createDate { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string fullName { get; set; }
        public string userCode { get; set; }
        public string emailAddr { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string paymentStatus { get; set; }
        public int orderNo { get; set; }
        public double invoiceDueTotal { get; set; }
        public double invoiceTotal { get; set; }
        public double taxAmount { get; set; }
        public double discountAmount { get; set; }
        public double dueAmount { get; set; }
        public string dueAmountInWord { get; set; }
        public double grandTotal { get; set; }
        public int userPackServiceId { get; set; }
    }
    public class vmLists
    {
        public int vmId { get; set; }
        public int cloudUserId { get; set; }
        public decimal costPerHour { get; set; }
    }

    public class vmCmnParameter
    {
        public int? id { get; set; }
        public string strId { get; set; }
        public string strId2 { get; set; }
        public int? pageNumber { get; set; }
        public int? pageSize { get; set; }
        public bool IsPaging { get; set; }
        public string SearchVal { get; set; }
        public string Name { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public string macAddress { get; set; }
        public string tablename { get; set; }
        public string property { get; set; }
        public string values { get; set; }
        public string UserID { get; set; }
        public string LoggedUserId { get; set; }
        public int? month { get; set; }
        public string ClientIP { get; set; }
        public bool IsLoggedIn { get; set; }
        public string Path { get; set; }
        public bool IsTrue { get; set; }
        public DateTime? SDate { get; set; }
        public DateTime? EDate { get; set; }
        public DateTime? CDate { get; set; }
        public bool IsEdit { get; set; }
        public string strYear { get; set; }
        public string strMonth { get; set; }
        public string strDay { get; set; }
        public string strTime { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public bool IsSys { get; set; }
    }

}
