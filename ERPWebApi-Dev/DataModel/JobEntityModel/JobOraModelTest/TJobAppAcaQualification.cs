using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppAcaQualification
    {
        public decimal Oid { get; set; }
        public string? Degree { get; set; }
        public string? Board { get; set; }
        public string? Institution { get; set; }
        public string? Major { get; set; }
        public decimal? Result { get; set; }
        public decimal? Passingyear { get; set; }
        public decimal? ApplicantOid { get; set; }

        public virtual TJobAppApplicantForm? ApplicantO { get; set; }
    }
}
