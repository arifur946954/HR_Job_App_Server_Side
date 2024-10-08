using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvInvoc
    {
        public TvInvoc()
        {
            TvMnrcvds = new HashSet<TvMnrcvd>();
        }

        public string Oid { get; set; } = null!;
        public string InvocInvno { get; set; } = null!;
        public string InvocSpblm { get; set; } = null!;
        public DateTime? InvocDate { get; set; }
        public string? InvocVtflg { get; set; }
        public string? InvocMnno { get; set; }
        public string? InvocMont { get; set; }
        public string? InvocYear { get; set; }
        public decimal? InvocAmnt { get; set; }
        public string? InvocType { get; set; }
        public string? InvocPosf { get; set; }
        public string? InvocFlag { get; set; }
        public byte? InvocPntflag { get; set; }
        public string? InvocPntuser { get; set; }
        public DateTime? InvocPntdate { get; set; }
        public string? InvocLine { get; set; }
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
        public string? InvocSbank { get; set; }

        public virtual ICollection<TvMnrcvd> TvMnrcvds { get; set; }
    }
}
