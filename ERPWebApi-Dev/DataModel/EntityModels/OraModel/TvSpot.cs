using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvSpot
    {
        public TvSpot()
        {
            TvBillds = new HashSet<TvBilld>();
            TvDelscduls = new HashSet<TvDelscdul>();
            TvSchedules = new HashSet<TvSchedule>();
            TvWrkords = new HashSet<TvWrkord>();
        }

        public string Oid { get; set; } = null!;
        public string SpotText { get; set; } = null!;
        public string SpotName { get; set; } = null!;
        public string? SpotActv { get; set; }
        public string? SpotStop { get; set; }
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

        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvDelscdul> TvDelscduls { get; set; }
        public virtual ICollection<TvSchedule> TvSchedules { get; set; }
        public virtual ICollection<TvWrkord> TvWrkords { get; set; }
    }
}
