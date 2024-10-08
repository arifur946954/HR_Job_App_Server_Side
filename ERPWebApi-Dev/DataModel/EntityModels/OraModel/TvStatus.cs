using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvStatus
    {
        public TvStatus()
        {
            TvBillsps = new HashSet<TvBillsp>();
            TvLscdlarcvDetls = new HashSet<TvLscdlarcvDetl>();
            TvLsscduls = new HashSet<TvLsscdul>();
            TvPenbils = new HashSet<TvPenbil>();
            TvWrklsds = new HashSet<TvWrklsd>();
        }

        public string Oid { get; set; } = null!;
        public string StatusText { get; set; } = null!;
        public string StatusName { get; set; } = null!;
        public string StatusSname { get; set; } = null!;
        public string? StatusType { get; set; }
        public string? StatusActv { get; set; }
        public string? StatusStop { get; set; }
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

        public virtual ICollection<TvBillsp> TvBillsps { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetls { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscduls { get; set; }
        public virtual ICollection<TvPenbil> TvPenbils { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsds { get; set; }
    }
}
