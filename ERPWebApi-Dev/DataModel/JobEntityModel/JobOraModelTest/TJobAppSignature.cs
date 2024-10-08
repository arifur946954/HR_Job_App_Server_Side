using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobAppSignature
    {
        public decimal Oid { get; set; }
        public byte[]? Signature { get; set; }
        public string? SignatureName { get; set; }
    }
}
