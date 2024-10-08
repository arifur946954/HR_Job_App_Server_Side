using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvCommRateHistory
    {
        public string Oid { get; set; } = null!;
        public string RateHistText { get; set; } = null!;
        public string RateHistHour { get; set; } = null!;
        public string RateHistClient { get; set; } = null!;
        public DateTime? RateHistOpdate { get; set; }
        public decimal? RateHistRate { get; set; }
        public string? RateHistActv { get; set; }
        public string? RateHistType { get; set; }
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? EditUser { get; set; }
        public DateTime? EditDate { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceUser { get; set; }
        public string? EditDeviceIp { get; set; }
        public string? EditDeviceName { get; set; }
        public string? EditDeviceUser { get; set; }

        public virtual TvClient RateHistClientNavigation { get; set; } = null!;
        public virtual TvHour RateHistHourNavigation { get; set; } = null!;
    }
}
