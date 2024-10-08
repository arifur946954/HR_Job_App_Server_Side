using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TWorkorderDetailBuying
    {
        public string Oid { get; set; } = null!;
        public decimal? Numid { get; set; }
        public string? WorkorderOid { get; set; }
        public decimal? WorkorderNumid { get; set; }
        public string? CategoryOid { get; set; }
        public string? PlatformOid { get; set; }
        public string? ParameterOid { get; set; }
        public string? ParameterTaskOid { get; set; }
        public string? MetricsOid { get; set; }
        public string? AssetTypeOid { get; set; }
        public DateTime? CampaignBeginDate { get; set; }
        public DateTime? CampaignEndDate { get; set; }
        public decimal? ConversionRate { get; set; }
        public decimal? CostPerResultUsd { get; set; }
        public decimal? CostPerResultBdt { get; set; }
        public decimal? TotalResult { get; set; }
        public decimal? ContentCount { get; set; }
        public decimal? TotalBudgetUsd { get; set; }
        public decimal? TotalBudgetBdt { get; set; }
        public decimal? AgencyChargePcnt { get; set; }
        public decimal? AgencyChargeTkUsd { get; set; }
        public decimal? AgencyChargeTkBdt { get; set; }
        public decimal? RemittancePcnt { get; set; }
        public decimal? RemittanceTkUsd { get; set; }
        public decimal? RemittanceTkBdt { get; set; }
        public decimal? SubTotalUsd { get; set; }
        public decimal? SubTotalBdt { get; set; }
        public decimal? VatPcnt { get; set; }
        public decimal? VatTkUsd { get; set; }
        public decimal? VatTkBdt { get; set; }
        public decimal? TotalUsd { get; set; }
        public decimal? TotalBdt { get; set; }
        public decimal? GrandTotalUsd { get; set; }
        public decimal? GrandTotalBdt { get; set; }
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
        public string? Assettypename { get; set; }
        public long? DiscountUsd { get; set; }
        public long? DiscountBdt { get; set; }
    }
}
