using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBplatform
    {
        public string Oid { get; set; } = null!;
        public string? BplatformTrno { get; set; }
        public string BplatformName { get; set; } = null!;
        public string? BplatformBname { get; set; }
        public string? BplatformSname { get; set; }
        public string CategoryOid { get; set; } = null!;
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
