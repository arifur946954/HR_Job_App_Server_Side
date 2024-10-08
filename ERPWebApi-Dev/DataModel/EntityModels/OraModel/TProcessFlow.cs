using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TProcessFlow
    {
        public string Processflowid { get; set; } = null!;
        public string Processflowcode { get; set; } = null!;
        public string Categoryid { get; set; } = null!;
        public string Isactive { get; set; } = null!;
        public string Iscancel { get; set; } = null!;
        public string Createpc { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public decimal? Menuid { get; set; }
    }
}
