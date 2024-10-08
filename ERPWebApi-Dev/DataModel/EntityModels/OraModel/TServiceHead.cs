using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TServiceHead
    {
        public string Oid { get; set; } = null!;
        public string? HeadCode { get; set; }
        public string? HeadName { get; set; }
        public string? HeadBname { get; set; }
        public string? HeadSname { get; set; }
        public string HeadGroupOid { get; set; } = null!;
        public string CategoryOid { get; set; } = null!;
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public long? HeadCost { get; set; }

        public virtual TCategory CategoryO { get; set; } = null!;
        public virtual TServiceHeadGroup HeadGroupO { get; set; } = null!;
    }
}
