using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvWrkord
    {
        public string Oid { get; set; } = null!;
        public string WrkordMaster { get; set; } = null!;
        public DateTime? WrkordDate { get; set; }
        public DateTime? WrkordFdate { get; set; }
        public DateTime? WrkordTdate { get; set; }
        public string? WrkordHour { get; set; }
        public string WrkordSprod { get; set; } = null!;
        public string? WrkordBreak { get; set; }
        public string? WrkordSpoot { get; set; }
        public string? WrkordProgm { get; set; }
        public string? WrkordPftime { get; set; }
        public string? WrkordFttime { get; set; }
        public string? WrkordFtime { get; set; }
        public string? WrkordTtime { get; set; }
        public string? WrkordTmdur { get; set; }
        public decimal? WrkordRate { get; set; }
        public string? WrkordActv { get; set; }
        public string? WrkordLine { get; set; }
        public string? WrkordType { get; set; }
        public string? Iuser { get; set; }
        public string? Euser { get; set; }
        public DateTime? Idat { get; set; }
        public DateTime? Edat { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceUser { get; set; }
        public string? EditDeviceIp { get; set; }
        public string? EditDeviceName { get; set; }
        public string? EditDeviceUser { get; set; }

        public virtual TvBreak? WrkordBreakNavigation { get; set; }
        public virtual TvHour? WrkordHourNavigation { get; set; }
        public virtual TvWrksdlMaster WrkordMasterNavigation { get; set; } = null!;
        public virtual TvProgm? WrkordProgmNavigation { get; set; }
        public virtual TvSpot? WrkordSpootNavigation { get; set; }
        public virtual TvSprod WrkordSprodNavigation { get; set; } = null!;
    }
}
