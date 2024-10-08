using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvLsscdulMaster
    {
        public TvLsscdulMaster()
        {
            TvLsscduls = new HashSet<TvLsscdul>();
        }

        public string Oid { get; set; } = null!;
        public string LscdlmText { get; set; } = null!;
        public DateTime? LscdlmCdate { get; set; }
        public DateTime? LscdlmSdate { get; set; }
        public string LscdlmHour { get; set; } = null!;
        public string? LscdlmPosf { get; set; }
        public string? LscdlmPntflg { get; set; }
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? Euser { get; set; }
        public DateTime? Edat { get; set; }
        public string? PrintBy { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceUser { get; set; }
        public string? EditDeviceIp { get; set; }
        public string? EditDeviceName { get; set; }
        public string? EditDeviceUser { get; set; }

        public virtual TvHour LscdlmHourNavigation { get; set; } = null!;
        public virtual ICollection<TvLsscdul> TvLsscduls { get; set; }
    }
}
