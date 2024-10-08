using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvWrklsdMaster
    {
        public TvWrklsdMaster()
        {
            TvWrklsds = new HashSet<TvWrklsd>();
        }

        public string Oid { get; set; } = null!;
        public string WrlsmText { get; set; } = null!;
        public DateTime? WrlsmCdate { get; set; }
        public DateTime? WrlsmSdate { get; set; }
        public string WrlsmHour { get; set; } = null!;
        public string? WrlsmPosf { get; set; }
        public string? WrlsmPntflg { get; set; }
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

        public virtual TvHour WrlsmHourNavigation { get; set; } = null!;
        public virtual ICollection<TvWrklsd> TvWrklsds { get; set; }
    }
}
