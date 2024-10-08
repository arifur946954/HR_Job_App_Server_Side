using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class EtCmnuser
    {
        public decimal Userid { get; set; }
        public string Customcode { get; set; } = null!;
        public decimal? Transactiontypeid { get; set; }
        public string? Employeeid { get; set; }
        public decimal? Usertypeid { get; set; }
        public decimal? Userdesignationid { get; set; }
        public decimal? Usergroupid { get; set; }
        public decimal? Usertitleid { get; set; }
        public decimal? Userparentid { get; set; }
        public string? Userfirstname { get; set; }
        public string? Usermiddlename { get; set; }
        public string? Userlastname { get; set; }
        public string? Userfullname { get; set; }
        public string? Telephone { get; set; }
        public string? Departmentname { get; set; }
        public string? Userjobtitle { get; set; }
        public string? Appointment { get; set; }
        public string? Remarks { get; set; }
        public decimal? Customeraccountid { get; set; }
        public string? Sapcustomerid { get; set; }
        public string? Contractemailid { get; set; }
        public string? Skypeid { get; set; }
        public string? Facebookid { get; set; }
        public string? Whatsapp { get; set; }
        public string? Viber { get; set; }
        public string? Linkedin { get; set; }
        public decimal? Religionid { get; set; }
        public string? Mobileno { get; set; }
        public decimal? Phoneno { get; set; }
        public string? Uniqueidentity { get; set; }
        public string? Officeid { get; set; }
        public decimal? Genderid { get; set; }
        public decimal? Isactive { get; set; }
        public DateTime? Effectivedate { get; set; }
        public decimal? Statusid { get; set; }
        public decimal Companyid { get; set; }
        public decimal? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public decimal? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public decimal Isdeleted { get; set; }
        public decimal? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
    }
}
