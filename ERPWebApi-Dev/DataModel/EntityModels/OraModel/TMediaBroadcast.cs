using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMediaBroadcast
    {
        public string Oid { get; set; } = null!;
        public string? BroadcastTrno { get; set; }
        public string? BroadcastName { get; set; }
        public string? BroadcastBname { get; set; }
        public string? BroadcastSname { get; set; }
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
