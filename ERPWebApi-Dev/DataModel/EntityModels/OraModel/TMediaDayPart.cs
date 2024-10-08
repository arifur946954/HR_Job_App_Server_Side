using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMediaDayPart
    {
        public string Oid { get; set; } = null!;
        public string? DaypartTrno { get; set; }
        public string? DaypartName { get; set; }
        public string? DaypartBname { get; set; }
        public string? DaypartSname { get; set; }
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
