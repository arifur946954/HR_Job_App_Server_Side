using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMenu
    {
        public TMenu()
        {
            TMnuds = new HashSet<TMnud>();
        }

        public string Oid { get; set; } = null!;
        public string MenuText { get; set; } = null!;
        public string MenuName { get; set; } = null!;
        public string? MenuActv { get; set; }
        public string? Web { get; set; }
        public string? MenuSeqn { get; set; }
        public string? MenuFlag { get; set; }
        public string? MenuMaster { get; set; }
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

        public virtual ICollection<TMnud> TMnuds { get; set; }
    }
}
