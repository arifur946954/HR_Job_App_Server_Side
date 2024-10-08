using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvWrksdlMaster
    {
        public TvWrksdlMaster()
        {
            TvWrkords = new HashSet<TvWrkord>();
        }

        public string Oid { get; set; } = null!;
        public string WrksdlTrno { get; set; } = null!;
        public DateTime? WrksdlDate { get; set; }
        public DateTime? WrksdlFdate { get; set; }
        public DateTime? WrksdlTdate { get; set; }
        public string WrksdlAgent { get; set; } = null!;
        public string WrksdlClient { get; set; } = null!;
        public string? WrksdlType { get; set; }
        public string? WrksdlActv { get; set; }
        public string? WrksdlFlag { get; set; }
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

        public virtual TvClient WrksdlAgentNavigation { get; set; } = null!;
        public virtual TvClient WrksdlClientNavigation { get; set; } = null!;
        public virtual ICollection<TvWrkord> TvWrkords { get; set; }
    }
}
