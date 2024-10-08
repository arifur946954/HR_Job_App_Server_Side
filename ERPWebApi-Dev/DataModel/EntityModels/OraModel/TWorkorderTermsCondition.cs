using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TWorkorderTermsCondition
    {
        public string Oid { get; set; } = null!;
        public string? WorkorderOid { get; set; }
        public decimal? Slnumber { get; set; }
        public string? Termsconditions { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createpc { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Cancelpc { get; set; }
        public string? Cancelby { get; set; }
        public DateTime? Cancelon { get; set; }
        public string? Tcoid { get; set; }
    }
}
