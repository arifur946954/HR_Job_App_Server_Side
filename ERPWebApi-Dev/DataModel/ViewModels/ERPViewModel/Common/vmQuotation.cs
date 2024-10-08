using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmQutationMaster
    {
        public decimal? QuotationId { get; set; }
        public string QuotRefNo { get; set; }
        public DateTime? QuotationDate { get; set; }
        public string CustomerId { get; set; }
        public string MarketingPersonId { get; set; }
        public int? QuotationTypeId { get; set; }
        public decimal? QuotationAmount { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
    }

    public class vmQutationDetail
    {
        public decimal? QuotDetailId { get; set; }
        public decimal? QuotationId { get; set; }
        public decimal? ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}
