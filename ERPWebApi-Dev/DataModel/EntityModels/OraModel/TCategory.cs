using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TCategory
    {
        public TCategory()
        {
            TBparameters = new HashSet<TBparameter>();
            TBplatforms = new HashSet<TBplatform>();
            TServiceHeads = new HashSet<TServiceHead>();
        }

        public string Oid { get; set; } = null!;
        public string? CategoryTrno { get; set; }
        public string? CategoryName { get; set; }
        public string? CategorySname { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string? CategoryBname { get; set; }

        public virtual ICollection<TBparameter> TBparameters { get; set; }
        public virtual ICollection<TBplatform> TBplatforms { get; set; }
        public virtual ICollection<TServiceHead> TServiceHeads { get; set; }
    }
}
