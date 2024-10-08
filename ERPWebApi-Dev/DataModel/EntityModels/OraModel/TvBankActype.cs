using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvBankActype
    {
        public TvBankActype()
        {
            TvBankAccnts = new HashSet<TvBankAccnt>();
        }

        public string Oid { get; set; } = null!;
        public string ActypeText { get; set; } = null!;
        public string ActypeName { get; set; } = null!;
        public string? ActypeActv { get; set; }
        public string? ActypeStop { get; set; }
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

        public virtual ICollection<TvBankAccnt> TvBankAccnts { get; set; }
    }
}
