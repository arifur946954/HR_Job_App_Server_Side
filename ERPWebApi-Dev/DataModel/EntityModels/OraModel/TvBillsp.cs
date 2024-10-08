using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvBillsp
    {
        public string Oid { get; set; } = null!;
        public string BillspSpblm { get; set; } = null!;
        public DateTime? BillspDatetime { get; set; }
        public string BillspStatus { get; set; } = null!;
        public string BillspHour { get; set; } = null!;
        public string BillspHour2 { get; set; } = null!;
        public string BillspLsscdul { get; set; } = null!;
        public string BillspSprod { get; set; } = null!;
        public string BillspProgm { get; set; } = null!;
        public string? BillspPftime { get; set; }
        public string? BillspPttime { get; set; }
        public string? BillspPname { get; set; }
        public decimal? BillspTldur { get; set; }
        public decimal? BillspDur { get; set; }
        public decimal? BillspSpno { get; set; }
        public decimal? BillspRate { get; set; }
        public string? BillspType { get; set; }
        public string? BillspCprod { get; set; }
        public string? BillspLine { get; set; }
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

        public virtual TvCprod? BillspCprodNavigation { get; set; }
        public virtual TvHour BillspHour2Navigation { get; set; } = null!;
        public virtual TvHour BillspHourNavigation { get; set; } = null!;
        public virtual TvLsscdul BillspLsscdulNavigation { get; set; } = null!;
        public virtual TvProgm BillspProgmNavigation { get; set; } = null!;
        public virtual TvSpblm BillspSpblmNavigation { get; set; } = null!;
        public virtual TvSprod BillspSprodNavigation { get; set; } = null!;
        public virtual TvStatus BillspStatusNavigation { get; set; } = null!;
    }
}
