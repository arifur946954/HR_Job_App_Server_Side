using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class EtCmnmenupermission
    {
        public decimal Menupermissionid { get; set; }
        public string? Customcode { get; set; }
        public decimal? Menuid { get; set; }
        public decimal? Usergroupid { get; set; }
        public string? Userid { get; set; }
        public decimal Enableview { get; set; }
        public decimal Enableinsert { get; set; }
        public decimal Enableupdate { get; set; }
        public decimal Enabledelete { get; set; }
        public decimal? Organogramid { get; set; }
        public decimal? Companyid { get; set; }
        public decimal? Isactive { get; set; }
        public DateTime? Effectivedate { get; set; }
        public decimal? Statusid { get; set; }
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
        public string? Oid { get; set; }
    }
}
