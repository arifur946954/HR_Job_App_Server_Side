using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TRoleSetup
    {
        public string Rolename { get; set; } = null!;
        public string? Remarks { get; set; }
        public string Isactive { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string Createpc { get; set; } = null!;
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string Isdelete { get; set; } = null!;
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletelpc { get; set; }
        public decimal Roleid { get; set; }
    }
}
