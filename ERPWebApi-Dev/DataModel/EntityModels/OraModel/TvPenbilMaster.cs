using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvPenbilMaster
    {
        public TvPenbilMaster()
        {
            TvPenbils = new HashSet<TvPenbil>();
        }

        public string Oid { get; set; } = null!;
        public string PenbilmstText { get; set; } = null!;
        public DateTime? PenbilmstDate { get; set; }
        public DateTime? PenbilmstLdate { get; set; }
        public string? PenbilmstPosf { get; set; }
        public string? PenbilmstPntflg { get; set; }
        public string? PenbilmstFlg { get; set; }
        public string? PenbilmstTxdt { get; set; }
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

        public virtual ICollection<TvPenbil> TvPenbils { get; set; }
    }
}
