using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvPenbil
    {
        public TvPenbil()
        {
            TvBillds = new HashSet<TvBilld>();
        }

        public string Oid { get; set; } = null!;
        public string PenbilMaster { get; set; } = null!;
        public DateTime? PenbilDate { get; set; }
        public DateTime? PenbilLdate { get; set; }
        public DateTime? PenbilDatetime { get; set; }
        public string PenbilLog { get; set; } = null!;
        public string? PenbilTime { get; set; }
        public string? PenbilType { get; set; }
        public string? PenbilCode { get; set; }
        public string? PenbilFtime { get; set; }
        public string? PenbilTtime { get; set; }
        public string PenbilSprod { get; set; } = null!;
        public string PenbilClient { get; set; } = null!;
        public string PenbilAgent { get; set; } = null!;
        public string PenbilHour { get; set; } = null!;
        public string? PenbilStatus { get; set; }
        public string? PenbilTmdur { get; set; }
        public string? PenbilCndur { get; set; }
        public decimal? PenbilRate { get; set; }
        public string? PenbilTxdt { get; set; }
        public string? PenbilFlag { get; set; }
        public string? PenbilBnflg { get; set; }
        public string? PenbilNote { get; set; }
        public string? PenbilPosf { get; set; }
        public string? PenbilLine { get; set; }
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
        public string? ApvDeviceIp { get; set; }
        public string? ApvDeviceName { get; set; }
        public string? ApvDeviceUser { get; set; }
        public DateTime? ApvDate { get; set; }
        public string? PenbilProcs { get; set; }

        public virtual TvClient PenbilAgentNavigation { get; set; } = null!;
        public virtual TvClient PenbilClientNavigation { get; set; } = null!;
        public virtual TvHour PenbilHourNavigation { get; set; } = null!;
        public virtual TvLog PenbilLogNavigation { get; set; } = null!;
        public virtual TvPenbilMaster PenbilMasterNavigation { get; set; } = null!;
        public virtual TvSprod PenbilSprodNavigation { get; set; } = null!;
        public virtual TvStatus? PenbilStatusNavigation { get; set; }
        public virtual ICollection<TvBilld> TvBillds { get; set; }
    }
}
