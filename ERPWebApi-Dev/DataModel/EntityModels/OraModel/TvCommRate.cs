using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvCommRate
    {
        public string Oid { get; set; } = null!;
        public string CommRateText { get; set; } = null!;
        public string CommRateHour { get; set; } = null!;
        public string CommRateClient { get; set; } = null!;
        public DateTime? CommRateOpdt { get; set; }
        public decimal? CommRateRate { get; set; }
        public string? CommRateActv { get; set; }
        public string? CommRateType { get; set; }
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

        public virtual TvClient CommRateClientNavigation { get; set; } = null!;
        public virtual TvHour CommRateHourNavigation { get; set; } = null!;
    }
}
