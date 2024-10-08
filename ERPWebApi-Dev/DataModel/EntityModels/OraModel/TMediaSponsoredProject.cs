using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMediaSponsoredProject
    {
        public string Oid { get; set; } = null!;
        public string? ProjectTrno { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectBname { get; set; }
        public string? ProjectSname { get; set; }
        public string? SponsorOid { get; set; }
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
