using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TProcessType
    {
        public string Processtypeid { get; set; } = null!;
        public string Processtype { get; set; } = null!;
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
    }
}
