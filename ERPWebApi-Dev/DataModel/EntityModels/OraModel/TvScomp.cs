using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvScomp
    {
        public TvScomp()
        {
            TvBankAccnts = new HashSet<TvBankAccnt>();
            TvSpblms = new HashSet<TvSpblm>();
        }

        public string Oid { get; set; } = null!;
        public string ScompText { get; set; } = null!;
        public string ScompName { get; set; } = null!;
        public string ScompBname { get; set; } = null!;
        public string? ScompMcom { get; set; }
        public string? ScompCcom { get; set; }
        public string? ScompActv { get; set; }
        public string? ScompStop { get; set; }
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
        public virtual ICollection<TvSpblm> TvSpblms { get; set; }
    }
}
