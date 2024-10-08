using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBparameter
    {
        public string Oid { get; set; } = null!;
        public string? BparameterTrno { get; set; }
        public string BparameterName { get; set; } = null!;
        public string? BparameterBname { get; set; }
        public string? BparameterSname { get; set; }
        public string CategoryOid { get; set; } = null!;
        public string? BplatformOid { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }

        public virtual TCategory CategoryO { get; set; } = null!;
    }
}
