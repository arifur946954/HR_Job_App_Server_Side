using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TQuotationTermsCondition
    {
        public string Oid { get; set; } = null!;
        public string QuotationOid { get; set; } = null!;
        public decimal? Slnumber { get; set; }
        public string? Termsconditions { get; set; }
        public string Isactive { get; set; } = null!;
        public string Iscancel { get; set; } = null!;
        public string Createpc { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Cancelpc { get; set; }
        public string? Cancelby { get; set; }
        public DateTime? Cancelon { get; set; }
        public string? Tcoid { get; set; }
    }
}
