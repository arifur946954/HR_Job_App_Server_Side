using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBmetric
    {
        public string Oid { get; set; } = null!;
        public string? BmetricsTrno { get; set; }
        public string? BmetricsName { get; set; }
        public long? BmetricsValue { get; set; }
        public string? BmetricsBname { get; set; }
        public string? BmetricsSname { get; set; }
        public string? CategoryOid { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
    }
}
