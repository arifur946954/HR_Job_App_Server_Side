using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class EtCmnmodule
    {
        public decimal Moduleid { get; set; }
        public string Customcode { get; set; } = null!;
        public string? Modulename { get; set; }
        public string? Description { get; set; }
        public string? Imageurl { get; set; }
        public string? Modulepath { get; set; }
        public decimal? Sequence { get; set; }
        public int? Statusid { get; set; }
        public int Companyid { get; set; }
        public int? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public int? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public bool? Isdeleted { get; set; }
        public int? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
    }
}
