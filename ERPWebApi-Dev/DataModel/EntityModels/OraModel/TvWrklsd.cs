using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvWrklsd
    {
        public TvWrklsd()
        {
            TvLscdlarcvDetls = new HashSet<TvLscdlarcvDetl>();
            TvLsscduls = new HashSet<TvLsscdul>();
        }

        public string Oid { get; set; } = null!;
        public string WrklsdMaster { get; set; } = null!;
        public DateTime? WrklsdSdate { get; set; }
        public DateTime? WrklsdCdate { get; set; }
        public string WrklsdStatus { get; set; } = null!;
        public string WrklsdClient { get; set; } = null!;
        public string WrklsdAgent { get; set; } = null!;
        public string WrklsdHour { get; set; } = null!;
        public string WrklsdHour2 { get; set; } = null!;
        public string WrklsdProgm { get; set; } = null!;
        public string WrklsdSprod { get; set; } = null!;
        public string WrklsdCode { get; set; } = null!;
        public string? WrklsdPname { get; set; }
        public string? WrklsdPftime { get; set; }
        public string? WrklsdPttime { get; set; }
        public decimal? WrklsdRate { get; set; }
        public string? WrklsdTotdur { get; set; }
        public string? WrklsdDuration { get; set; }
        public string? WrklsdSpno { get; set; }
        public int? WrklsdSeqn { get; set; }
        public string? WrklsdType { get; set; }
        public string? WrklsdPosf { get; set; }
        public string? WrklsdDay { get; set; }
        public string? WrklsdColr { get; set; }
        public string? WrklsdFlag { get; set; }
        public string? WrklsdNote { get; set; }
        public string? WrklsdPend { get; set; }
        public string? WrklsdLine { get; set; }
        public string? WrklsdStop { get; set; }
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
        public string? WrklsdApproveby { get; set; }
        public DateTime? WrklsdAppvdate { get; set; }
        public string? WrklsdAppvdur { get; set; }
        public string? WrklsdAppvspno { get; set; }
        public string? WrklsdAppvfalg { get; set; }

        public virtual TvClient WrklsdAgentNavigation { get; set; } = null!;
        public virtual TvClient WrklsdClientNavigation { get; set; } = null!;
        public virtual TvHour WrklsdHour2Navigation { get; set; } = null!;
        public virtual TvHour WrklsdHourNavigation { get; set; } = null!;
        public virtual TvWrklsdMaster WrklsdMasterNavigation { get; set; } = null!;
        public virtual TvProgm WrklsdProgmNavigation { get; set; } = null!;
        public virtual TvSprod WrklsdSprodNavigation { get; set; } = null!;
        public virtual TvStatus WrklsdStatusNavigation { get; set; } = null!;
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetls { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscduls { get; set; }
    }
}
