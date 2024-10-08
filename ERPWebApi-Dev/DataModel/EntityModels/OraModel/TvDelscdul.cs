using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvDelscdul
    {
        public string Oid { get; set; } = null!;
        public string DelscdulMaster { get; set; } = null!;
        public DateTime? DelscdulCdate { get; set; }
        public DateTime? DelscdulSdate { get; set; }
        public string DelscdulHour { get; set; } = null!;
        public string DelscdulProgm { get; set; } = null!;
        public string DelscdulClient { get; set; } = null!;
        public string DelscdulAgent { get; set; } = null!;
        public string DelscdulBreak { get; set; } = null!;
        public string DelscdulSpot { get; set; } = null!;
        public string DelscdulSprod { get; set; } = null!;
        public string DelscdulCode { get; set; } = null!;
        public string? DelscdulPftime { get; set; }
        public string? DelscdulPttime { get; set; }
        public string? DelscdulFtime { get; set; }
        public string? DelscdulTtime { get; set; }
        public string? DelscdulSptm { get; set; }
        public string? DelscdulTmdur { get; set; }
        public decimal? DelscdulRate { get; set; }
        public string? DelscdulType { get; set; }
        public string? DelscdulPend { get; set; }
        public string? DelscdulColr { get; set; }
        public string? DelscdulPnam { get; set; }
        public string? DelscdulCtyp { get; set; }
        public string? DelscdulTpid { get; set; }
        public string? DelscdulCmtim { get; set; }
        public string? DelscdulFlag { get; set; }
        public string? DelscdulStatus { get; set; }
        public string? DelscdulClnsts { get; set; }
        public string? DelscdulPosf { get; set; }
        public string? DelscdulWrkord { get; set; }
        public int? DelscdulSeqn { get; set; }
        public string? DelscdulLine { get; set; }
        public string DelscdulSchedule { get; set; } = null!;
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

        public virtual TvClient DelscdulAgentNavigation { get; set; } = null!;
        public virtual TvBreak DelscdulBreakNavigation { get; set; } = null!;
        public virtual TvClient DelscdulClientNavigation { get; set; } = null!;
        public virtual TvHour DelscdulHourNavigation { get; set; } = null!;
        public virtual TvDelscdulMaster DelscdulMasterNavigation { get; set; } = null!;
        public virtual TvProgm DelscdulProgmNavigation { get; set; } = null!;
        public virtual TvSpot DelscdulSpotNavigation { get; set; } = null!;
        public virtual TvSprod DelscdulSprodNavigation { get; set; } = null!;
    }
}
