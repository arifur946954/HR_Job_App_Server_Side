using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvRcvtype
    {
        public TvRcvtype()
        {
            TvMnrcvds = new HashSet<TvMnrcvd>();
        }

        public string Oid { get; set; } = null!;
        public string RcvtypeText { get; set; } = null!;
        public string RcvtypeName { get; set; } = null!;
        public string RcvtypeSname { get; set; } = null!;
        public string? RcvtypeActv { get; set; }
        public string? RcvtypeStop { get; set; }
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

        public virtual ICollection<TvMnrcvd> TvMnrcvds { get; set; }
    }
}
