using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvSpblm
    {
        public TvSpblm()
        {
            TvBillds = new HashSet<TvBilld>();
            TvBillsps = new HashSet<TvBillsp>();
            TvMnrcvds = new HashSet<TvMnrcvd>();
            TvSpblds = new HashSet<TvSpbld>();
        }

        public string Oid { get; set; } = null!;
        public string SpblmCont { get; set; } = null!;
        public string SpblmVtflg { get; set; } = null!;
        public DateTime? SpblmTrdt { get; set; }
        public DateTime? SpblmCondt { get; set; }
        public DateTime? SpblmStdt { get; set; }
        public DateTime? SpblmEndt { get; set; }
        public string SpblmAgent { get; set; } = null!;
        public string SpblmClient { get; set; } = null!;
        public string? SpblmCprod { get; set; }
        public string? SpblmCprod2 { get; set; }
        public string? SpblmCprod3 { get; set; }
        public string? SpblmTprat { get; set; }
        public decimal? SpblmRate { get; set; }
        public decimal? SpblmEpsod { get; set; }
        public decimal? SpblmDur { get; set; }
        public decimal? SpblmVat { get; set; }
        public decimal? SpblmAgency { get; set; }
        public decimal? SpblmAit { get; set; }
        public decimal? SpblmSpadj { get; set; }
        public decimal? SpblmAit2 { get; set; }
        public decimal? SpblmAmnt { get; set; }
        public string? SpblmNote { get; set; }
        public string? SpblmType { get; set; }
        public string? SpblmPosf { get; set; }
        public string? SpblmFlag { get; set; }
        public byte? SpblmPntflag { get; set; }
        public string? SpblmPntuser { get; set; }
        public DateTime? SpblmPntdate { get; set; }
        public string SpblmScomp { get; set; } = null!;
        public string? SpblmMcom { get; set; }
        public string? SpblmCcom { get; set; }
        public string SpblmAgloc { get; set; } = null!;
        public string SpblmSgloc { get; set; } = null!;
        public string SpblmDrcshd { get; set; } = null!;
        public string SpblmDraccd { get; set; } = null!;
        public string SpblmCrcshd { get; set; } = null!;
        public string? SpblmSraccd { get; set; }
        public string? SpblmVtaccd { get; set; }
        public string? SpblmAgaccd { get; set; }
        public string? SpblmAiaccd { get; set; }
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
        public string? SpblmMushok { get; set; }
        public DateTime? SpblmMukdate { get; set; }

        public virtual TvClient SpblmAgentNavigation { get; set; } = null!;
        public virtual TvClient SpblmClientNavigation { get; set; } = null!;
        public virtual TvCprod? SpblmCprod2Navigation { get; set; }
        public virtual TvCprod? SpblmCprod3Navigation { get; set; }
        public virtual TvCprod? SpblmCprodNavigation { get; set; }
        public virtual TvScomp SpblmScompNavigation { get; set; } = null!;
        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvBillsp> TvBillsps { get; set; }
        public virtual ICollection<TvMnrcvd> TvMnrcvds { get; set; }
        public virtual ICollection<TvSpbld> TvSpblds { get; set; }
    }
}
