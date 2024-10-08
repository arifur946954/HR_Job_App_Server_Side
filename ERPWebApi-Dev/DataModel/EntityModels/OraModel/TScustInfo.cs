using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TScustInfo
    {
        public string Oid { get; set; } = null!;
        public string ScustInfoText { get; set; } = null!;
        public string ScustInfoName { get; set; } = null!;
        public DateTime? ScustInfoOpdt { get; set; }
        public string? ScustInfoBnam { get; set; }
        public string? ScustInfoOwnr { get; set; }
        public string? ScustInfoCper { get; set; }
        public string ScustInfoSctyp { get; set; } = null!;
        public string ScustInfoSstyp { get; set; } = null!;
        public string ScustInfoScuntry { get; set; } = null!;
        public string? ScustInfoPhno { get; set; }
        public string? ScustInfoFxno { get; set; }
        public string? ScustInfoEmal { get; set; }
        public decimal? ScustInfoCrdt { get; set; }
        public string? ScustInfoAdd1 { get; set; }
        public string? ScustInfoAdd2 { get; set; }
        public string? ScustInfoBad1 { get; set; }
        public string? ScustInfoBad2 { get; set; }
        public string? ScustInfoActv { get; set; }
        public string? Iuser { get; set; }
        public string? Euser { get; set; }
        public DateTime? Idat { get; set; }
        public DateTime? Edat { get; set; }
        public int? Ver { get; set; }
        public DateTime? Udt { get; set; }
        public string? ScustInfoTrdn { get; set; }
        public string? ScustInfoBlock { get; set; }
        public string? ScustInfoBtype { get; set; }
        public string? ScustInfoVtid { get; set; }
        public string? ScustInfoSincat { get; set; }
        public string? ScustInfoInasp { get; set; }
        public string? ScustInfoBangl { get; set; }
        public string? ScustInfoCtype { get; set; }
        public long? ScustInfoBkgrnt { get; set; }
        public DateTime? ScustInfoBkgopdt { get; set; }
        public DateTime? ScustInfoBkgcldt { get; set; }
        public string? ScustInfoSbank { get; set; }
        public string? ScustInfoBrnch { get; set; }
        public string? ScustInfoBgno { get; set; }
        public string? ScustInfoTenor { get; set; }
        public string? ScustInfoUniname { get; set; }
        public string? ScustInfoUniadd { get; set; }
        public string? ScustInfoClient { get; set; }
    }
}
