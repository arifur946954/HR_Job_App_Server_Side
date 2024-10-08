using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppImage
    {
        public decimal Oid { get; set; }
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
    }
}
