using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TUserRole
    {
        public string UserId { get; set; } = null!;
        public decimal RoleId { get; set; }
        public decimal Userroleid { get; set; }
        public string? Createpc { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Deletepc { get; set; }
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string Isdelete { get; set; } = null!;
        public string Isactive { get; set; } = null!;
    }
}
