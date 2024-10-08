using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobApplicantMaster
    {
        public string Oid { get; set; } = null!;
        public string ApplicantCode { get; set; } = null!;
        public string? MobileNumber { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public string? Nid { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? BirthPlace { get; set; }
        public string? Religion { get; set; }
        public string? BloodGroup { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? SpouseName { get; set; }
        public string? Email { get; set; }
        public string? AppliedPost { get; set; }
        public string? Isactive { get; set; }
        public string? Isdelete { get; set; }
        public string? Createpc { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Deletepc { get; set; }
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? PreAddDivision { get; set; }
        public string? PerAddDistrict { get; set; }
        public string? PreAddThana { get; set; }
        public string? PreAddPostOffice { get; set; }
        public string? PreAddVillage { get; set; }
        public string? ParAddDivision { get; set; }
        public string? ParAddDistrict { get; set; }
        public string? ParAddThana { get; set; }
        public string? ParAddPostOffice { get; set; }
        public string? ParAddVillage { get; set; }
        public string? ExpectedSelery { get; set; }
        public string? AppliedBy { get; set; }
        public string? Department { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string? CompanyName { get; set; }
        public string? JobTitle { get; set; }
        public string? CompanyDeptPost { get; set; }
        public string? CompanyDeptPostOpenDate { get; set; }
        public string? CompanyDeptPostActiveStatus { get; set; }
        public string? ImagePath { get; set; }
        public string? SignaturePath { get; set; }
        public string? CvPath { get; set; }
        public string? Jobid { get; set; }
        public string? Post { get; set; }
    }
}
