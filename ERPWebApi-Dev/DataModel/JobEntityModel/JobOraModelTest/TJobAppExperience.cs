using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppExperience
    {
        public decimal Oid { get; set; }
        public string? Post { get; set; }
        public string? Organization { get; set; }
        public string? JobLocation { get; set; }
        public string? Salary { get; set; }
        public string? ReportingTo { get; set; }
        public string? DefaultProduct { get; set; }
        public decimal? ApplicantOid { get; set; }

        public virtual TJobAppApplicantForm? ApplicantO { get; set; }
    }
}
