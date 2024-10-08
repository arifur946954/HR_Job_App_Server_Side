using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TCmnmenupermission
    {
        public decimal Menupermissionid { get; set; }
        public decimal? Menuid { get; set; }
        public decimal Roleid { get; set; }
        public string Enableview { get; set; } = null!;
        public string Enableinsert { get; set; } = null!;
        public string Enableupdate { get; set; } = null!;
        public string Enabledelete { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string Createpc { get; set; } = null!;
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string Isdelete { get; set; } = null!;
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
    }
}
