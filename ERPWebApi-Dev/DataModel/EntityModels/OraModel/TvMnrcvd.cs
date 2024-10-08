using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvMnrcvd
    {
        public string Oid { get; set; } = null!;
        public string MnrcvdSmnyrm { get; set; } = null!;
        public string MnrcvdRcvtype { get; set; } = null!;
        public string MnrcvdAgent { get; set; } = null!;
        public string MnrcvdClient { get; set; } = null!;
        public string? MnrcvdInvoc { get; set; }
        public string? MnrcvdSpblm { get; set; }
        public string? MnrcvdNote { get; set; }
        public decimal? MnrcvdAmnt { get; set; }
        public string? MnrcvdPosf { get; set; }
        public string MnrcvdSgloc { get; set; } = null!;
        public string MnrcvdScomp { get; set; } = null!;
        public string MnrcvdMrno { get; set; } = null!;
        public string MnrcvdScust { get; set; } = null!;
        public string MnrcvdSmode { get; set; } = null!;
        public string MnrcvdSbank { get; set; } = null!;
        public string MnrcvdDocn { get; set; } = null!;
        public string? MnrcvdLine { get; set; }
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
        public string? MnrcvdLocshd { get; set; }
        public string? MnrcvdDraccd { get; set; }
        public string? MnrcvdCraccd { get; set; }
        public DateTime? MnrcvdDate { get; set; }

        public virtual TvClient MnrcvdAgentNavigation { get; set; } = null!;
        public virtual TvClient MnrcvdClientNavigation { get; set; } = null!;
        public virtual TvInvoc? MnrcvdInvocNavigation { get; set; }
        public virtual TvRcvtype MnrcvdRcvtypeNavigation { get; set; } = null!;
        public virtual TvSpblm? MnrcvdSpblmNavigation { get; set; }
    }
}
