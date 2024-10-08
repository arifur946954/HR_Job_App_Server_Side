using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvSprod
    {
        public TvSprod()
        {
            TvBillds = new HashSet<TvBilld>();
            TvBillsps = new HashSet<TvBillsp>();
            TvDelscduls = new HashSet<TvDelscdul>();
            TvLscdlarcvDetls = new HashSet<TvLscdlarcvDetl>();
            TvLsscduls = new HashSet<TvLsscdul>();
            TvPenbils = new HashSet<TvPenbil>();
            TvSchedules = new HashSet<TvSchedule>();
            TvWrklsds = new HashSet<TvWrklsd>();
            TvWrkords = new HashSet<TvWrkord>();
        }

        public string Oid { get; set; } = null!;
        public string SprodText { get; set; } = null!;
        public DateTime? SprodOpndt { get; set; }
        public string SprodClient { get; set; } = null!;
        public string SprodCode { get; set; } = null!;
        public string SprodName { get; set; } = null!;
        public string? SprodDur { get; set; }
        public string? SprodActv { get; set; }
        public string? SprodStop { get; set; }
        public string? SprodType { get; set; }
        public string SprodAgent { get; set; } = null!;
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

        public virtual TvClient SprodAgentNavigation { get; set; } = null!;
        public virtual TvClient SprodClientNavigation { get; set; } = null!;
        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvBillsp> TvBillsps { get; set; }
        public virtual ICollection<TvDelscdul> TvDelscduls { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetls { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscduls { get; set; }
        public virtual ICollection<TvPenbil> TvPenbils { get; set; }
        public virtual ICollection<TvSchedule> TvSchedules { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsds { get; set; }
        public virtual ICollection<TvWrkord> TvWrkords { get; set; }
    }
}
