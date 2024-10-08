using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppAddress
    {
        public decimal Oid { get; set; }
        public string? PresAddDivision { get; set; }
        public string? PersAddDistrict { get; set; }
        public string? PresAddThana { get; set; }
        public string? PresAddPostOffice { get; set; }
        public string? PresAddVillage { get; set; }
        public string? ParmAddDivision { get; set; }
        public string? ParmAddDistrict { get; set; }
        public string? ParmAddThana { get; set; }
        public string? ParmAddPostOffice { get; set; }
        public string? ParmAddVillage { get; set; }
        public decimal? ApplicantOid { get; set; }

        public virtual TJobAppApplicantForm? ApplicantO { get; set; }
    }
}
