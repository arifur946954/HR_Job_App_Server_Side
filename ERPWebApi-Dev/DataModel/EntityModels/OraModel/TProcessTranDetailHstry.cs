using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TProcessTranDetailHstry
    {
        public string Transactiondetilhistoryid { get; set; } = null!;
        public string Transactiondetailid { get; set; } = null!;
        public string Transactionid { get; set; } = null!;
        public string? Fromuserid { get; set; }
        public string? Touserid { get; set; }
        public string Userid { get; set; } = null!;
        public decimal? Status { get; set; }
        public string? Isapproved { get; set; }
        public string? Comments { get; set; }
        public string Isactive { get; set; } = null!;
        public string Iscancel { get; set; } = null!;
        public string Createpc { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
    }
}
