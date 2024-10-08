//using DataModels.ViewModels.ERPViewModel.SalesMarketing;
using System.Threading.Tasks;

namespace DataModel.ViewModels
{
    public class vmLoggeduser
    {
        public int? UserID { get; set; }
        public int? UserType { get; set; }
        public int? RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int? CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string FullName { get; set; }
        public string CompanyLogo { get; set; }
        public string ReportLogo { get; set; }
        public int? BusinessId { get; set; }
        public bool? IsBillingUser { get; set; }
        public  string processFlowTeamCode  { get; set; }
    }
   
    public class vmportalLoggeduser
    {
        public int? UserID { get; set; }
        public string UserCode { get; set; }
        public int? UserType { get; set; }
        public int? RoleID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string userAddress { get; set; }
        public int? CompanyID { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public string PrePostpaid { get; set; }
        public string ActivationProfileId { get; set; }
        public string Created { get; set; }
        public string LastUpdated { get; set; }
        public string companyName { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string Timezone { get; set; }
        public bool? isTrial { get; set; }
        public bool? canDeploy { get; set; }
        public bool? canModify { get; set; }
       
    }

    public class vmIspPortalLoggeduser
    {
        public int? UserID { get; set; }
        public int? UserType { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int? CompanyID { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public string Status { get; set; }

        public string Profile { get; set; }
        public int? ProfileId { get; set; }
        public string Created { get; set; }
        public string LastUpdated { get; set; }
        public string CompanyName { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal UpRate { get; set; }
        public decimal DownRate { get; set; }
    }

}
