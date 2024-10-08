using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobApplicantAcaQualification
    {
        public string Oid { get; set; } = null!;
        public string AcdmicqlfCode { get; set; } = null!;
        public string? Degree { get; set; }
        public string? Board { get; set; }
        public string? Institution { get; set; }
        public string? Major { get; set; }
        public decimal? Result { get; set; }
        public decimal? Passingyear { get; set; }
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
        public string? ApplicantOid { get; set; }
    }
}
