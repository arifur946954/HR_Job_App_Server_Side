using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TQuotationMaster
    {
        public TQuotationMaster()
        {
            TQuotationDetailMedia = new HashSet<TQuotationDetailMedium>();
            TQuotationDetailPrints = new HashSet<TQuotationDetailPrint>();
            TQuotationDetails = new HashSet<TQuotationDetail>();
        }

        public string Oid { get; set; } = null!;
        public decimal Numid { get; set; }
        public string? QuotCode { get; set; }
        public string? QuotRefNo { get; set; }
        public string? QuotType { get; set; }
        public DateTime? QuotDate { get; set; }
        public string ClientOid { get; set; } = null!;
        public string CategoryOid { get; set; } = null!;
        public decimal? AgencyChargePcnt { get; set; }
        public decimal? AgencyChargeTk { get; set; }
        public decimal? DevelopmentCharge { get; set; }
        public decimal? AdvancedPcnt { get; set; }
        public decimal? AdvancedTk { get; set; }
        public decimal? QuotSubtotal { get; set; }
        public decimal? QuotTotal { get; set; }
        public decimal? QuotGrandtotal { get; set; }
        public string? Remarks { get; set; }
        public string? Ispost { get; set; }
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
        public DateTime? Reviseddate { get; set; }
        public string? Isinprocess { get; set; }
        public string? Isprocesscomplete { get; set; }
        public string? Islock { get; set; }
        public long? EarningTk { get; set; }
        public long? VatPcnt { get; set; }
        public long? VatTk { get; set; }
        public long? RemittanceTk { get; set; }
        public long? RowTotal { get; set; }
        public string? Programme { get; set; }
        public string? Currencyid { get; set; }
        public long? Conversionrate { get; set; }
        public long? RemittancePcnt { get; set; }
        public string? Invoiceno { get; set; }
        public string? Isinvoice { get; set; }
        public string? Isworkorder { get; set; }
        public string? Workorderno { get; set; }
        public string? Brandname { get; set; }
        public string? Campaign { get; set; }
        public string? Director { get; set; }
        public string? DirectorMusic { get; set; }
        public string? Dop { get; set; }
        public string? Producer { get; set; }
        public string? ProdHouse { get; set; }
        public string? ShootDays { get; set; }
        public string? VideoDuration { get; set; }
        public string? VideoFormat { get; set; }
        public long? DiscountPcnt { get; set; }
        public long? DiscountTk { get; set; }
        public long? DiscountUsd { get; set; }

        public virtual ICollection<TQuotationDetailMedium> TQuotationDetailMedia { get; set; }
        public virtual ICollection<TQuotationDetailPrint> TQuotationDetailPrints { get; set; }
        public virtual ICollection<TQuotationDetail> TQuotationDetails { get; set; }
    }
}
