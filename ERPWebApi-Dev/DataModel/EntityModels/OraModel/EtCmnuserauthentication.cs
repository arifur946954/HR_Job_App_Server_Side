using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class EtCmnuserauthentication
    {
        public decimal Authenticationid { get; set; }
        public string Userid { get; set; } = null!;
        public string? Loginemail { get; set; }
        public string? Loginphone { get; set; }
        public string Password { get; set; } = null!;
        public string Confirmpassword { get; set; } = null!;
        public DateTime? Registrationdate { get; set; }
        public DateTime? Expiredate { get; set; }
        public DateTime? Activationdate { get; set; }
        public string? Activationcode { get; set; }
        public decimal? Statusid { get; set; }
        public decimal? Languageid { get; set; }
        public decimal? Timezoneid { get; set; }
        public decimal? Allowmultiplelogin { get; set; }
        public string? Nooflogin { get; set; }
        public decimal? Isfirstlogin { get; set; }
        public decimal Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public decimal? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public decimal Isdeleted { get; set; }
        public decimal? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
        public decimal Companyid { get; set; }
        public string? Encryptpassword { get; set; }
    }
}
