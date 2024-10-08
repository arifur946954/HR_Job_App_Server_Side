using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBplacement
    {
        public string Oid { get; set; } = null!;
        public string? BplacementTrno { get; set; }
        public string BplacementName { get; set; } = null!;
        public string? BplacementBname { get; set; }
        public string? BplacementSname { get; set; }
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
