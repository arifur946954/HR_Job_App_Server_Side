using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppCircular
    {
        public decimal Oid { get; set; }
        public string? CompanyName { get; set; }
        public string? DepartmentName { get; set; }
        public string? Post { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public string? ActiveStatus { get; set; }
        public DateTime? CircularStartDate { get; set; }
        public DateTime? CircularEndDate { get; set; }
        public string? CompanyDeptPost { get; set; }
        public string? CompanyDeptPostOpenDate { get; set; }
        public string? CompanyDeptPostActiveStatus { get; set; }
    }
}
