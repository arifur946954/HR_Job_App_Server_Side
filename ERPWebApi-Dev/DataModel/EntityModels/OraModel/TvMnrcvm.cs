using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvMnrcvm
    {
        public string Oid { get; set; } = null!;
        public string MnrcvmMrno { get; set; } = null!;
        public string? MnrcvmType { get; set; }
        public DateTime? MnrcvmMrdt { get; set; }
        public string MnrcvmScomp { get; set; } = null!;
        public string MnrcvmAgent { get; set; } = null!;
        public string MnrcvmClient { get; set; } = null!;
        public string MnrcvmScustInfo { get; set; } = null!;
        public string MnrcvmSgloc { get; set; } = null!;
        public string? MnrcvmNote { get; set; }
        public string? MnrcvmPosf { get; set; }
        public string? MnrcvmOtgloc { get; set; }
        public string? MnrcvmSctyp { get; set; }
        public string? MnrcvmAgloc { get; set; }
        public string? MnrcvmMcom { get; set; }
        public string? MnrcvmCcom { get; set; }
        public string? MnrcvmHocshd { get; set; }
        public string? Iuser { get; set; }
        public string? Euser { get; set; }
        public DateTime? Idat { get; set; }
        public DateTime? Edat { get; set; }
        public string? MnrcvmRefno { get; set; }

        public virtual TvClient MnrcvmAgentNavigation { get; set; } = null!;
        public virtual TvClient MnrcvmClientNavigation { get; set; } = null!;
    }
}
