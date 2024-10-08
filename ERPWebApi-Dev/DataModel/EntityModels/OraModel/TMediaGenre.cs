using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMediaGenre
    {
        public string Oid { get; set; } = null!;
        public string? GenreTrno { get; set; }
        public string? GenreName { get; set; }
        public string? GenreBname { get; set; }
        public string? GenreSname { get; set; }
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
