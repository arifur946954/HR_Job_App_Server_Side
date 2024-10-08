using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvSchedule
    {
        public string Oid { get; set; } = null!;
        public string ScheduleMaster { get; set; } = null!;
        public DateTime? ScheduleCdate { get; set; }
        public DateTime? ScheduleSdate { get; set; }
        public string ScheduleHour { get; set; } = null!;
        public string ScheduleProgm { get; set; } = null!;
        public string ScheduleClient { get; set; } = null!;
        public string ScheduleAgent { get; set; } = null!;
        public string ScheduleBreak { get; set; } = null!;
        public string ScheduleSpot { get; set; } = null!;
        public string ScheduleSprod { get; set; } = null!;
        public string ScheduleCode { get; set; } = null!;
        public string? SchedulePftime { get; set; }
        public string? SchedulePttime { get; set; }
        public string? ScheduleFtime { get; set; }
        public string? ScheduleTtime { get; set; }
        public string? ScheduleSptm { get; set; }
        public string? ScheduleTmdur { get; set; }
        public decimal? ScheduleRate { get; set; }
        public string? ScheduleType { get; set; }
        public string? SchedulePend { get; set; }
        public string? ScheduleColr { get; set; }
        public string? SchedulePnam { get; set; }
        public string? ScheduleCtyp { get; set; }
        public string? ScheduleTpid { get; set; }
        public string? ScheduleCmtim { get; set; }
        public string? ScheduleFlag { get; set; }
        public string? ScheduleStatus { get; set; }
        public string? ScheduleClnsts { get; set; }
        public string? SchedulePosf { get; set; }
        public string? ScheduleWrkord { get; set; }
        public int? ScheduleSeqn { get; set; }
        public string? ScheduleLine { get; set; }
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? Euser { get; set; }
        public DateTime? Edat { get; set; }
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
        public string? AmnedDeviceIp { get; set; }
        public string? AmnedDeviceUser { get; set; }
        public string? AmnedUser { get; set; }
        public DateTime? AmnedDate { get; set; }
        public string? ScheduleFnlfg { get; set; }

        public virtual TvClient ScheduleAgentNavigation { get; set; } = null!;
        public virtual TvBreak ScheduleBreakNavigation { get; set; } = null!;
        public virtual TvClient ScheduleClientNavigation { get; set; } = null!;
        public virtual TvHour ScheduleHourNavigation { get; set; } = null!;
        public virtual TvScheduleMaster ScheduleMasterNavigation { get; set; } = null!;
        public virtual TvProgm ScheduleProgmNavigation { get; set; } = null!;
        public virtual TvSpot ScheduleSpotNavigation { get; set; } = null!;
        public virtual TvSprod ScheduleSprodNavigation { get; set; } = null!;
    }
}
