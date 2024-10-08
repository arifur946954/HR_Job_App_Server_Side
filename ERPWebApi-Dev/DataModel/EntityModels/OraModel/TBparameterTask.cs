using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBparameterTask
    {
        public string Oid { get; set; } = null!;
        public string? BparametertaskTrno { get; set; }
        public string? BparametertaskName { get; set; }
        public string? BparametertaskBname { get; set; }
        public string? BparametertaskSname { get; set; }
        public string? CategoryOid { get; set; }
        public string? BplatformOid { get; set; }
        public string? BparameterOid { get; set; }
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
