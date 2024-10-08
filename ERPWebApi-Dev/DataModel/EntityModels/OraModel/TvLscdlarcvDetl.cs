using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvLscdlarcvDetl
    {
        public string Oid { get; set; } = null!;
        public string ArcvlsdlMaster { get; set; } = null!;
        public string ArcvlsdlStatus { get; set; } = null!;
        public DateTime? ArcvlsdlSdate { get; set; }
        public DateTime? ArcvlsdlCdate { get; set; }
        public string ArcvlsdlClient { get; set; } = null!;
        public string ArcvlsdlAgent { get; set; } = null!;
        public string ArcvlsdlHour { get; set; } = null!;
        public string ArcvlsdlHour2 { get; set; } = null!;
        public string ArcvlsdlProgm { get; set; } = null!;
        public string ArcvlsdlSprod { get; set; } = null!;
        public string ArcvlsdlCode { get; set; } = null!;
        public string? ArcvlsdlPname { get; set; }
        public string? ArcvlsdlPftime { get; set; }
        public string? ArcvlsdlPttime { get; set; }
        public decimal? ArcvlsdlRate { get; set; }
        public string? ArcvlsdlTotdur { get; set; }
        public string? ArcvlsdlDuration { get; set; }
        public string? ArcvlsdlSpno { get; set; }
        public int? ArcvlsdlSeqn { get; set; }
        public string? ArcvlsdlType { get; set; }
        public string? ArcvlsdlPosf { get; set; }
        public string? ArcvlsdlDay { get; set; }
        public string? ArcvlsdlColr { get; set; }
        public string? ArcvlsdlFlag { get; set; }
        public string? ArcvlsdlNote { get; set; }
        public string? ArcvlsdlPend { get; set; }
        public string? ArcvlsdlLine { get; set; }
        public string? ArcvlsdlStop { get; set; }
        public string? ArcvlsdlFnpost { get; set; }
        public string? ArcvlsdlWrklsd { get; set; }
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
        public string? ArcvlsdlApproveby { get; set; }
        public DateTime? ArcvlsdlAppvdate { get; set; }
        public string? ArcvlsdlAppvdur { get; set; }
        public string? ArcvlsdlAppvspno { get; set; }
        public string? ArcvlsdlAppvfalg { get; set; }
        public string? ArcvlsdlLsscdul { get; set; }

        public virtual TvClient ArcvlsdlAgentNavigation { get; set; } = null!;
        public virtual TvClient ArcvlsdlClientNavigation { get; set; } = null!;
        public virtual TvHour ArcvlsdlHour2Navigation { get; set; } = null!;
        public virtual TvHour ArcvlsdlHourNavigation { get; set; } = null!;
        public virtual TvLscdlarcvMaster ArcvlsdlMasterNavigation { get; set; } = null!;
        public virtual TvProgm ArcvlsdlProgmNavigation { get; set; } = null!;
        public virtual TvSprod ArcvlsdlSprodNavigation { get; set; } = null!;
        public virtual TvStatus ArcvlsdlStatusNavigation { get; set; } = null!;
        public virtual TvWrklsd? ArcvlsdlWrklsdNavigation { get; set; }
    }
}
