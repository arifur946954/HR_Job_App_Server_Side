using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TQuotationsDetail
    {
        public string Oid { get; set; } = null!;
        public decimal? Numid { get; set; }
        public string? QuotOid { get; set; }
        public decimal? QuotNumid { get; set; }
        public string? CategoryOid { get; set; }
        public string? HeadGroupOid { get; set; }
        public string? HeadOid { get; set; }
        public string? Narration { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Daysshift { get; set; }
        public decimal? Total { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string? Cancelby { get; set; }
        public DateTime? Cancelon { get; set; }
        public string? Cancelpc { get; set; }
        public long? Setno { get; set; }
        public long? Seton { get; set; }
    }
}
