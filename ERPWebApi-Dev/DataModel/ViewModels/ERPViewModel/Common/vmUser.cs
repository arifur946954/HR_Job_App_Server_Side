//using DataModels.EntityModels.ERPModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmUser
    {
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public int? CompanyId { get; set; }
        public int? BusinessId { get; set; }
        public int? ServiceId { get; set; }
        public int? UserTypeId { get; set; }
        public int? UserRoleId { get; set; }
        public int? UserGroupId { get; set; }
        public string FullName { get; set; }
        public string FrstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address1Present { get; set; }
        public string Address2Present { get; set; }
        public string Address1Permanent { get; set; }
        public string Address2Permanent { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Long { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public bool? IsAlertEmail { get; set; }
        public bool? IsAlertSms { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }


        public string TypeName { get; set; }
        public string RoleName { get; set; }
    }
}
