using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TUserMenu
    {
        public string Oid { get; set; } = null!;
        public string UsermenuMnud { get; set; } = null!;
        public string UsermenuUser { get; set; } = null!;
        public string? UsermenuActv { get; set; }
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

        public virtual TMnud UsermenuMnudNavigation { get; set; } = null!;
        public virtual TUser UsermenuUserNavigation { get; set; } = null!;
    }
}
