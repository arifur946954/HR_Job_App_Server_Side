using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TClient
    {
        public TClient()
        {
            TClientBanks = new HashSet<TClientBank>();
        }

        public string Oid { get; set; } = null!;
        public string? ClientCode { get; set; }
        public string? ClientName { get; set; }
        public string? ClientBname { get; set; }
        public string? ClientOwner { get; set; }
        public string? ClientContactPerson { get; set; }
        public string? ClientEmail { get; set; }
        public string? ClientMobile { get; set; }
        public string? ClientFax { get; set; }
        public string? ClientAddress { get; set; }
        public string? ClientBaddress { get; set; }
        public string? ClientAddress2 { get; set; }
        public string? ClientBaddress2 { get; set; }
        public string? ClientBin { get; set; }
        public decimal? ClientCreditLimit { get; set; }
        public DateTime? ClientEnrolldate { get; set; }
        public string? ClientType { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string? ClientTin { get; set; }
        public string? ClientSname { get; set; }
        public string? ClientDesig { get; set; }

        public virtual ICollection<TClientBank> TClientBanks { get; set; }
    }
}
