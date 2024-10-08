using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TBpublisher
    {
        public string Oid { get; set; } = null!;
        public string? BpublisherTrno { get; set; }
        public string? BpublisherName { get; set; }
        public string? BpublisherBname { get; set; }
        public string? BpublisherSname { get; set; }
        public string? CategoryOid { get; set; }
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
