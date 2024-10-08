using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TServiceHeadGroup
    {
        public TServiceHeadGroup()
        {
            TServiceHeads = new HashSet<TServiceHead>();
        }

        public string Oid { get; set; } = null!;
        public string? HeadGroupCode { get; set; }
        public string? HeadGroupName { get; set; }
        public string? HeadGroupBname { get; set; }
        public string? HeadGroupSname { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }

        public virtual ICollection<TServiceHead> TServiceHeads { get; set; }
    }
}
