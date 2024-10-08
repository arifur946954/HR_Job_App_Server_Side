using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobApplicantExperience
    {
        public string Oid { get; set; } = null!;
        public string Experienceid { get; set; } = null!;
        public string? Post { get; set; }
        public string? Organization { get; set; }
        public string? JobLocation { get; set; }
        public string? Salary { get; set; }
        public string? ReportingTo { get; set; }
        public string? DefaultProduct { get; set; }
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
