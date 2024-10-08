using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TClientBank
    {
        public string Oid { get; set; } = null!;
        public string? ClientBankCode { get; set; }
        public string ClientId { get; set; } = null!;
        public string ClientBankId { get; set; } = null!;
        public string? ClientBankBranch { get; set; }
        public string? ClientBankRouting { get; set; }
        public string? ClientBankSwiftcode { get; set; }
        public string? ClientAccountName { get; set; }
        public string? ClientAccountNumber { get; set; }
        public string? ClientAccountType { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }

        public virtual TClient Client { get; set; } = null!;
    }
}
