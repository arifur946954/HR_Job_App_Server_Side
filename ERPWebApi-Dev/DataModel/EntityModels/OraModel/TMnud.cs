using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMnud
    {
        public TMnud()
        {
            TUserMenus = new HashSet<TUserMenu>();
        }

        public string Oid { get; set; } = null!;
        public string MnudText { get; set; } = null!;
        public string MnudMenu { get; set; } = null!;
        public string MnudName { get; set; } = null!;
        public string? MnudActv { get; set; }
        public string? MnudHnam { get; set; }
        public string? MnudPage { get; set; }
        public string? MnudDnam { get; set; }
        public string? MnudSeqn { get; set; }
        public string? MnudFlag { get; set; }
        public string? MnudMnam { get; set; }
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

        public virtual TMenu MnudMenuNavigation { get; set; } = null!;
        public virtual ICollection<TUserMenu> TUserMenus { get; set; }
    }
}
