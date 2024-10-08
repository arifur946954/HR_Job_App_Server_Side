using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBassetType
    {
        public string Oid { get; set; } = null!;
        public string? BassettypeTrno { get; set; }
        public string? BassettypeName { get; set; }
        public string? BassettypeBname { get; set; }
        public string? BassettypeSname { get; set; }
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
