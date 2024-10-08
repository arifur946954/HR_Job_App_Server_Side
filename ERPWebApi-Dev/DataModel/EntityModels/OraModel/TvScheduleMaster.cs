using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvScheduleMaster
    {
        public TvScheduleMaster()
        {
            TvSchedules = new HashSet<TvSchedule>();
        }

        public string Oid { get; set; } = null!;
        public string SchdlmText { get; set; } = null!;
        public DateTime? SchdlmCdate { get; set; }
        public DateTime? SchdlmSdate { get; set; }
        public string SchdlmHour { get; set; } = null!;
        public string? SchdlmPosf { get; set; }
        public string? SchdlmPntflg { get; set; }
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? Euser { get; set; }
        public DateTime? Edat { get; set; }
        public string? PrintBy { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? VerifiedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DeviceIp { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceUser { get; set; }
        public string? EditDeviceIp { get; set; }
        public string? EditDeviceName { get; set; }
        public string? EditDeviceUser { get; set; }

        public virtual TvHour SchdlmHourNavigation { get; set; } = null!;
        public virtual ICollection<TvSchedule> TvSchedules { get; set; }
    }
}
