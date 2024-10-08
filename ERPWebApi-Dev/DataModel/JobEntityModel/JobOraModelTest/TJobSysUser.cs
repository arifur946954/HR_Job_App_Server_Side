using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobSysUser
    {
        public decimal Sysid { get; set; }
        public string Userid { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Fullname { get; set; }
        public string Isactive { get; set; } = null!;
        public string Isdelete { get; set; } = null!;
        public string Createpc { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Deletepc { get; set; }
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Email { get; set; }
        public string? Photo { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? Issys { get; set; }
    }
}
