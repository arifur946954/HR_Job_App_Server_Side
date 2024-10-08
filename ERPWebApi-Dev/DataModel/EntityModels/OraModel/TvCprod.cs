using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvCprod
    {
        public TvCprod()
        {
            TvBillds = new HashSet<TvBilld>();
            TvBillsps = new HashSet<TvBillsp>();
            TvSpblmSpblmCprod2Navigations = new HashSet<TvSpblm>();
            TvSpblmSpblmCprod3Navigations = new HashSet<TvSpblm>();
            TvSpblmSpblmCprodNavigations = new HashSet<TvSpblm>();
        }

        public string Oid { get; set; } = null!;
        public string CprodText { get; set; } = null!;
        public string CprodName { get; set; } = null!;
        public string CprodSname { get; set; } = null!;
        public string CprodClient { get; set; } = null!;
        public decimal? CprodRate { get; set; }
        public string? CprodActv { get; set; }
        public string? CprodType { get; set; }
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

        public virtual TvClient CprodClientNavigation { get; set; } = null!;
        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvBillsp> TvBillsps { get; set; }
        public virtual ICollection<TvSpblm> TvSpblmSpblmCprod2Navigations { get; set; }
        public virtual ICollection<TvSpblm> TvSpblmSpblmCprod3Navigations { get; set; }
        public virtual ICollection<TvSpblm> TvSpblmSpblmCprodNavigations { get; set; }
    }
}
