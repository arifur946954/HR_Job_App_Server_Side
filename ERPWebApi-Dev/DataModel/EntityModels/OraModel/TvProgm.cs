using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvProgm
    {
        public TvProgm()
        {
            TvBillds = new HashSet<TvBilld>();
            TvBillsps = new HashSet<TvBillsp>();
            TvDelscduls = new HashSet<TvDelscdul>();
            TvLscdlarcvDetls = new HashSet<TvLscdlarcvDetl>();
            TvLsscduls = new HashSet<TvLsscdul>();
            TvSchedules = new HashSet<TvSchedule>();
            TvWrklsds = new HashSet<TvWrklsd>();
            TvWrkords = new HashSet<TvWrkord>();
        }

        public string Oid { get; set; } = null!;
        public string ProgmText { get; set; } = null!;
        public string ProgmName { get; set; } = null!;
        public string? ProgmCode { get; set; }
        public string ProgmHour { get; set; } = null!;
        public DateTime? ProgmOpdate { get; set; }
        public DateTime? ProgmDftime { get; set; }
        public string? ProgmFtime { get; set; }
        public DateTime? ProgmDttime { get; set; }
        public string? ProgmTtime { get; set; }
        public string? ProgmDurtn { get; set; }
        public string? ProgmSeqn { get; set; }
        public string? ProgmActv { get; set; }
        public string? ProgmStop { get; set; }
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
        public string? ProgmAllot { get; set; }

        public virtual TvHour ProgmHourNavigation { get; set; } = null!;
        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvBillsp> TvBillsps { get; set; }
        public virtual ICollection<TvDelscdul> TvDelscduls { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetls { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscduls { get; set; }
        public virtual ICollection<TvSchedule> TvSchedules { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsds { get; set; }
        public virtual ICollection<TvWrkord> TvWrkords { get; set; }
    }
}
