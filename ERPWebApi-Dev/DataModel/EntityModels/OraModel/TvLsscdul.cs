using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvLsscdul
    {
        public TvLsscdul()
        {
            TvBillsps = new HashSet<TvBillsp>();
        }

        public string Oid { get; set; } = null!;
        public string LsscdulMaster { get; set; } = null!;
        public string LsscdulStatus { get; set; } = null!;
        public DateTime? LsscdulSdate { get; set; }
        public DateTime? LsscdulCdate { get; set; }
        public string LsscdulClient { get; set; } = null!;
        public string LsscdulAgent { get; set; } = null!;
        public string LsscdulHour { get; set; } = null!;
        public string LsscdulHour2 { get; set; } = null!;
        public string LsscdulProgm { get; set; } = null!;
        public string LsscdulSprod { get; set; } = null!;
        public string LsscdulCode { get; set; } = null!;
        public string? LsscdulPname { get; set; }
        public string? LsscdulPftime { get; set; }
        public string? LsscdulPttime { get; set; }
        public decimal? LsscdulRate { get; set; }
        public string? LsscdulTotdur { get; set; }
        public string? LsscdulDuration { get; set; }
        public string? LsscdulSpno { get; set; }
        public int? LsscdulSeqn { get; set; }
        public string? LsscdulType { get; set; }
        public string? LsscdulPosf { get; set; }
        public string? LsscdulDay { get; set; }
        public string? LsscdulColr { get; set; }
        public string? LsscdulFlag { get; set; }
        public string? LsscdulNote { get; set; }
        public string? LsscdulPend { get; set; }
        public string? LsscdulLine { get; set; }
        public string? LsscdulStop { get; set; }
        public string? LsscdulFnpost { get; set; }
        public string? LsscdulWrklsd { get; set; }
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
        public string? LsscdulApproveby { get; set; }
        public DateTime? LsscdulAppvdate { get; set; }
        public string? LsscdulAppvdur { get; set; }
        public string? LsscdulAppvspno { get; set; }
        public string? LsscdulAppvfalg { get; set; }

        public virtual TvClient LsscdulAgentNavigation { get; set; } = null!;
        public virtual TvClient LsscdulClientNavigation { get; set; } = null!;
        public virtual TvHour LsscdulHour2Navigation { get; set; } = null!;
        public virtual TvHour LsscdulHourNavigation { get; set; } = null!;
        public virtual TvLsscdulMaster LsscdulMasterNavigation { get; set; } = null!;
        public virtual TvProgm LsscdulProgmNavigation { get; set; } = null!;
        public virtual TvSprod LsscdulSprodNavigation { get; set; } = null!;
        public virtual TvStatus LsscdulStatusNavigation { get; set; } = null!;
        public virtual TvWrklsd? LsscdulWrklsdNavigation { get; set; }
        public virtual ICollection<TvBillsp> TvBillsps { get; set; }
    }
}
