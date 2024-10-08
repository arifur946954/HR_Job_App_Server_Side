using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvLogMaster
    {
        public TvLogMaster()
        {
            TvLogs = new HashSet<TvLog>();
        }

        public string Oid { get; set; } = null!;
        public string LogmstText { get; set; } = null!;
        public DateTime? LogmstDate { get; set; }
        public DateTime? LogmstSdate { get; set; }
        public string? LogmstPosf { get; set; }
        public string? LogmstPntflg { get; set; }
        public string? LogmstFlg { get; set; }
        public string? LogmstTxdt { get; set; }
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? Euser { get; set; }
        public DateTime? Edat { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceUser { get; set; }
        public string? EditDeviceIp { get; set; }
        public string? EditDeviceName { get; set; }
        public string? EditDeviceUser { get; set; }

        public virtual ICollection<TvLog> TvLogs { get; set; }
    }
}
