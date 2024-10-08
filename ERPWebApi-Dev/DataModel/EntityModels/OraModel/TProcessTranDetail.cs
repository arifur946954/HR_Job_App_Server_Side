using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TProcessTranDetail
    {
        public string Transactiondetailid { get; set; } = null!;
        public string Transactionid { get; set; } = null!;
        public string Referenceid { get; set; } = null!;
        public string Categoryid { get; set; } = null!;
        public string Processflowid { get; set; } = null!;
        public string Processflowdetailid { get; set; } = null!;
        public string Processtypeid { get; set; } = null!;
        public decimal Currentsequence { get; set; }
        public string? Fromuserid { get; set; }
        public string? Touserid { get; set; }
        public string Userid { get; set; } = null!;
        public decimal Status { get; set; }
        public string? Isapprovedall { get; set; }
        public string? Isapproved { get; set; }
        public string? Isdeclined { get; set; }
        public string? Approveduserid { get; set; }
        public string? Declineduserid { get; set; }
        public string? Comments { get; set; }
        public string? Approvedcomments { get; set; }
        public string? Declinedcomments { get; set; }
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
