using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvDelscdulMaster
    {
        public TvDelscdulMaster()
        {
            TvDelscduls = new HashSet<TvDelscdul>();
        }

        public string Oid { get; set; } = null!;
        public string DelscdlmText { get; set; } = null!;
        public DateTime? DelscdlmCdate { get; set; }
        public DateTime? DelscdlmSdate { get; set; }
        public string DelscdlmHour { get; set; } = null!;
        public string? DelscdlmPosf { get; set; }
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

        public virtual TvHour DelscdlmHourNavigation { get; set; } = null!;
        public virtual ICollection<TvDelscdul> TvDelscduls { get; set; }
    }
}
