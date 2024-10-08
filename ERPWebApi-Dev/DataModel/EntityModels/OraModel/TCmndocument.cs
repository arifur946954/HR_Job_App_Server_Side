using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TCmndocument
    {
        public decimal Documentid { get; set; }
        public decimal? Referenceid { get; set; }
        public string? Documentname { get; set; }
        public string? Documenttype { get; set; }
        public decimal? Documentsize { get; set; }
        public string? Basepath { get; set; }
        public string? Documentpath { get; set; }
        public string? Documentfullpath { get; set; }
        public string? Virtualpath { get; set; }
        public string? Isactive { get; set; }
        public string? Isdelete { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string? Deleteby { get; set; }
        public DateTime? Deleteon { get; set; }
        public string? Deletepc { get; set; }
        public string? Originaldocname { get; set; }
    }
}
