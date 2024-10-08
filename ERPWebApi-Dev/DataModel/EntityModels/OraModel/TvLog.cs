using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvLog
    {
        public TvLog()
        {
            TvBillds = new HashSet<TvBilld>();
            TvPenbils = new HashSet<TvPenbil>();
        }

        public string Oid { get; set; } = null!;
        public string LogMaster { get; set; } = null!;
        public DateTime? LogDate { get; set; }
        public DateTime? LogSdate { get; set; }
        public string? LogCode { get; set; }
        public string? LogPftime { get; set; }
        public string? LogPttime { get; set; }
        public string? LogDuration { get; set; }
        public string? LogReasult { get; set; }
        public string? LogProgdtls { get; set; }
        public string? LogProvenance { get; set; }
        public string? LogNote { get; set; }
        public string? LogType { get; set; }
        public string? LogExtr1 { get; set; }
        public string? LogExtr2 { get; set; }
        public string? LogExtr3 { get; set; }
        public string? LogExtr4 { get; set; }
        public string? LogRamcom { get; set; }
        public string? LogPath { get; set; }
        public string? LogStatus { get; set; }
        public string? LogFlag { get; set; }
        public string? LogPosf { get; set; }
        public string? LogTxdt { get; set; }
        public string? LogLine { get; set; }
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
        public string? LogApproveby { get; set; }
        public DateTime? LogAppvdate { get; set; }
        public string? LogAppvdur { get; set; }
        public string? LogAppvspno { get; set; }
        public string? LogAppvfalg { get; set; }
        public string? DeviceId { get; set; }

        public virtual TvLogMaster LogMasterNavigation { get; set; } = null!;
        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvPenbil> TvPenbils { get; set; }
    }
}
