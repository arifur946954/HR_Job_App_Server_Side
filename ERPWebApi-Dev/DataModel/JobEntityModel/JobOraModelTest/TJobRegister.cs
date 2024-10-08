using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobRegister
    {
        public string Oid { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string? Empid { get; set; }
        public string? Mobilenumber { get; set; }
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public string? Isactive { get; set; }
        public string? Isdelete { get; set; }
        public string? Createpc { get; set; }
        public DateTime? Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public string? Updateon { get; set; }
        public string? Deletepc { get; set; }
        public string? Deleteby { get; set; }
        public string? Deleteon { get; set; }
        public string Email { get; set; } = null!;
        public string? Photo { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? Isreg { get; set; }
    }
}
