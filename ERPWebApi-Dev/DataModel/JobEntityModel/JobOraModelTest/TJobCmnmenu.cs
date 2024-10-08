using System;
using System.Collections.Generic;

namespace DataModel.JobEntityModel.JobOraModelTest
{
    public partial class TJobCmnmenu
    {
        public decimal Menuid { get; set; }
        public string Menuname { get; set; } = null!;
        public string? Menushortname { get; set; }
        public decimal? Moduleid { get; set; }
        public string Menupath { get; set; } = null!;
        public decimal? Sequence { get; set; }
        public decimal? Menutypeid { get; set; }
        public string Createby { get; set; } = null!;
        public DateTime Createon { get; set; }
        public string Createpc { get; set; } = null!;
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string? Isactive { get; set; }
        public string? Isdelete { get; set; }
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
        public decimal? Parentid { get; set; }
        public decimal? Subparentid { get; set; }
        public string? Issubparent { get; set; }
        public string? Menuicon { get; set; }
    }
}
