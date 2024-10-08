using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Business
{
    public class vmClient
    {
        public string Oid { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientBname { get; set; }
        public string ClientOwner { get; set; }
        public string ClientContactPerson { get; set; }
        public string ClientEmail { get; set; }
        public string ClientMobile { get; set; }
        public string ClientFax { get; set; }
        public string ClientAddress { get; set; }
        public string ClientBaddress { get; set; }
        public string ClientAddress2 { get; set; }
        public string ClientBaddress2 { get; set; }
        public string ClientBin { get; set; }
        public string ClientTin { get; set; }
        public decimal? ClientCreditLimit { get; set; }
        public DateTime? ClientEnrolldate { get; set; }
        public string ClientType { get; set; }
        public bool Isactive { get; set; }
    }
}
