using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class EtCmnmodulepermission
    {
        public int Modulepermissionid { get; set; }
        public string Customcode { get; set; } = null!;
        public int? Moduleid { get; set; }
        public int Companyid { get; set; }
        public int? Statusid { get; set; }
        public int? Menulistid { get; set; }
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
