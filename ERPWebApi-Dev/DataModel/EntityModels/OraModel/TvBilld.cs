using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvBilld
    {
        public string Oid { get; set; } = null!;
        public string BilldSpblm { get; set; } = null!;
        public string BilldHour { get; set; } = null!;
        public string BilldBreak { get; set; } = null!;
        public string BilldPenbil { get; set; } = null!;
        public string BilldLog { get; set; } = null!;
        public string BilldSpot { get; set; } = null!;
        public string BilldProgm { get; set; } = null!;
        public string BilldSprod { get; set; } = null!;
        public string? BilldCprod { get; set; }
        public string? BilldPftime { get; set; }
        public string? BilldPttime { get; set; }
        public string? BilldLogdur { get; set; }
        public string? BilldNdur { get; set; }
        public decimal? BilldRate { get; set; }
        public string? BilldLine { get; set; }
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? Euser { get; set; }
        public DateTime? Edat { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceUser { get; set; }
        public string? EditDeviceIp { get; set; }
        public string? EditDeviceName { get; set; }
        public string? EditDeviceUser { get; set; }

        public virtual TvBreak BilldBreakNavigation { get; set; } = null!;
        public virtual TvCprod? BilldCprodNavigation { get; set; }
        public virtual TvHour BilldHourNavigation { get; set; } = null!;
        public virtual TvLog BilldLogNavigation { get; set; } = null!;
        public virtual TvPenbil BilldPenbilNavigation { get; set; } = null!;
        public virtual TvProgm BilldProgmNavigation { get; set; } = null!;
        public virtual TvSpblm BilldSpblmNavigation { get; set; } = null!;
        public virtual TvSpot BilldSpotNavigation { get; set; } = null!;
        public virtual TvSprod BilldSprodNavigation { get; set; } = null!;
    }
}
