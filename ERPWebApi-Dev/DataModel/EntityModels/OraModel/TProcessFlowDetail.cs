using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TProcessFlowDetail
    {
        public string Processflowdetailid { get; set; } = null!;
        public string Processflowid { get; set; } = null!;
        public string Processtypeid { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string Categoryid { get; set; } = null!;
        public decimal Sequences { get; set; }
        public string Isactive { get; set; } = null!;
        public string Iscancel { get; set; } = null!;
        public string Createpc { get; set; } = null!;
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string? Updatepc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
    }
}
