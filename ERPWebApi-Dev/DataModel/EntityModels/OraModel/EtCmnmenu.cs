using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class EtCmnmenu
    {
        public decimal Menuid { get; set; }
        public string Customcode { get; set; } = null!;
        public string? Menuname { get; set; }
        public string? Menushortname { get; set; }
        public decimal? Moduleid { get; set; }
        public string? Menupath { get; set; }
        public string? Reportname { get; set; }
        public string? Reportpath { get; set; }
        public decimal? Parentid { get; set; }
        public decimal? Sequence { get; set; }
        public decimal? Menutypeid { get; set; }
        public string? Menuiconcss { get; set; }
        public decimal? Statusid { get; set; }
        public decimal Companyid { get; set; }
        public decimal? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public decimal? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public decimal Isdeleted { get; set; }
        public decimal? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
    }
}
