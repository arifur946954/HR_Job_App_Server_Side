using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TWorkorderDetailMedium
    {
        public string Oid { get; set; } = null!;
        public decimal? Numid { get; set; }
        public string? WorkorderOid { get; set; }
        public decimal? WorkorderNumid { get; set; }
        public string? CategoryOid { get; set; }
        public string? BroadcastOid { get; set; }
        public string? ProgramOid { get; set; }
        public string? GenreOid { get; set; }
        public string? DayOid { get; set; }
        public string? DaypartOid { get; set; }
        public string? SponsorOid { get; set; }
        public string? ProjectOid { get; set; }
        public string? AdPositionOid { get; set; }
        public string? ProgramBegin { get; set; }
        public string? ProgramEnd { get; set; }
        public string? CampaignName { get; set; }
        public decimal? DurationSec { get; set; }
        public decimal? TotalSpots { get; set; }
        public decimal? TotalDuration { get; set; }
        public decimal? NegotiatedCost { get; set; }
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
        public long? DiscountTk { get; set; }

        public virtual TWorkorderMaster? WorkorderO { get; set; }
    }
}
