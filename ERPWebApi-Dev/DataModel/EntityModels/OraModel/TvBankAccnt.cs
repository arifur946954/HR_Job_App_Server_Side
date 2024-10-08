using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvBankAccnt
    {
        public string Oid { get; set; } = null!;
        public string AccntText { get; set; } = null!;
        public string? AccntName { get; set; }
        public string? AccntScomp { get; set; }
        public string AccntActype { get; set; } = null!;
        public string AccntMbank { get; set; } = null!;
        public DateTime? AccntOpdate { get; set; }
        public string? AccntAccno { get; set; }
        public string? AccntBranch { get; set; }
        public string? AccntTtfg { get; set; }
        public string? AccntClsfg { get; set; }
        public string? AccntRefcode { get; set; }
        public string? AccntActv { get; set; }
        public string? AccntPosf { get; set; }
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

        public virtual TvBankActype AccntActypeNavigation { get; set; } = null!;
        public virtual TvMbank AccntMbankNavigation { get; set; } = null!;
        public virtual TvScomp? AccntScompNavigation { get; set; }
    }
}
