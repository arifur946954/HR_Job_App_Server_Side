using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TErrorLog
    {
        public decimal Errorid { get; set; }
        public string Errormessage { get; set; } = null!;
        public string? Stacktrace { get; set; }
        public string? Spname { get; set; }
        public string? Apipath { get; set; }
        public string? Requesttype { get; set; }
        public string? Ipaddress { get; set; }
        public string? Browser { get; set; }
        public string? Createby { get; set; }
        public string Createon { get; set; } = null!;
        public string? Createpc { get; set; }
        public string? Clientagent { get; set; }
    }
}
