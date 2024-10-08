using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvSpbld
    {
        public string Oid { get; set; } = null!;
        public string SpbldSpblm { get; set; } = null!;
        public string SpbldHour { get; set; } = null!;
        public string? SpbldSpdt { get; set; }
        public string? SpbldMont { get; set; }
        public string? SpbldYear { get; set; }
        public string? SpbldNo { get; set; }
        public string? SpbldTot { get; set; }
        public string? SpbldLine { get; set; }
        public byte? SpbldPnttc { get; set; }
        public string? SpbldPntuser { get; set; }
        public DateTime? SpbldPntdate { get; set; }
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

        public virtual TvHour SpbldHourNavigation { get; set; } = null!;
        public virtual TvSpblm SpbldSpblmNavigation { get; set; } = null!;
    }
}
