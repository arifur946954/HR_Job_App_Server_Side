using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppCv
    {
        public decimal Oid { get; set; }
        public byte[]? Cv { get; set; }
        public string? CvName { get; set; }
    }
}
