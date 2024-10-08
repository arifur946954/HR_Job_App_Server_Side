using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TQuotationDetailPrint
    {
        public string Oid { get; set; } = null!;
        public decimal? Numid { get; set; }
        public string? QuotOid { get; set; }
        public decimal? QuotNumid { get; set; }
        public string? CategoryOid { get; set; }
        public DateTime? EstimatedDate { get; set; }
        public string? PublisherOid { get; set; }
        public string? SupplementOid { get; set; }
        public decimal? AreaSize { get; set; }
        public decimal? UnitRate { get; set; }
        public decimal? InsertCount { get; set; }
        public decimal? BasicCost { get; set; }
        public decimal? Discount { get; set; }
        public decimal? CostAfterRebate { get; set; }
        public decimal? CostBeforeAsf { get; set; }
        public decimal? AgencyChargePcnt { get; set; }
        public decimal? AgencyChargeTk { get; set; }
        public decimal? CostAfterAsf { get; set; }
        public decimal? VatPcnt { get; set; }
        public decimal? VatTk { get; set; }
        public decimal? Total { get; set; }
        public decimal? GrandTotal { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
        public string? Cancelby { get; set; }
        public DateTime? Cancelon { get; set; }
        public string? Cancelpc { get; set; }
        public string? PlacementOid { get; set; }
        public long? DiscountTk { get; set; }

        public virtual TQuotationMaster? QuotO { get; set; }
    }
}
