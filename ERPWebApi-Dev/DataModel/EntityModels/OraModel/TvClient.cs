using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvClient
    {
        public TvClient()
        {
            TvCommRateHistories = new HashSet<TvCommRateHistory>();
            TvCommRates = new HashSet<TvCommRate>();
            TvCprods = new HashSet<TvCprod>();
            TvDelscdulDelscdulAgentNavigations = new HashSet<TvDelscdul>();
            TvDelscdulDelscdulClientNavigations = new HashSet<TvDelscdul>();
            TvLscdlarcvDetlArcvlsdlAgentNavigations = new HashSet<TvLscdlarcvDetl>();
            TvLscdlarcvDetlArcvlsdlClientNavigations = new HashSet<TvLscdlarcvDetl>();
            TvLsscdulLsscdulAgentNavigations = new HashSet<TvLsscdul>();
            TvLsscdulLsscdulClientNavigations = new HashSet<TvLsscdul>();
            TvMnrcvdMnrcvdAgentNavigations = new HashSet<TvMnrcvd>();
            TvMnrcvdMnrcvdClientNavigations = new HashSet<TvMnrcvd>();
            TvMnrcvmMnrcvmAgentNavigations = new HashSet<TvMnrcvm>();
            TvMnrcvmMnrcvmClientNavigations = new HashSet<TvMnrcvm>();
            TvPenbilPenbilAgentNavigations = new HashSet<TvPenbil>();
            TvPenbilPenbilClientNavigations = new HashSet<TvPenbil>();
            TvScheduleScheduleAgentNavigations = new HashSet<TvSchedule>();
            TvScheduleScheduleClientNavigations = new HashSet<TvSchedule>();
            TvSpblmSpblmAgentNavigations = new HashSet<TvSpblm>();
            TvSpblmSpblmClientNavigations = new HashSet<TvSpblm>();
            TvSprodSprodAgentNavigations = new HashSet<TvSprod>();
            TvSprodSprodClientNavigations = new HashSet<TvSprod>();
            TvWrklsdWrklsdAgentNavigations = new HashSet<TvWrklsd>();
            TvWrklsdWrklsdClientNavigations = new HashSet<TvWrklsd>();
            TvWrksdlMasterWrksdlAgentNavigations = new HashSet<TvWrksdlMaster>();
            TvWrksdlMasterWrksdlClientNavigations = new HashSet<TvWrksdlMaster>();
        }

        public string Oid { get; set; } = null!;
        public string ClientText { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public string? ClientBname { get; set; }
        public string? ClientOwnr { get; set; }
        public string? ClientConper { get; set; }
        public DateTime? ClientOpdt { get; set; }
        public string? ClientPhno { get; set; }
        public string? ClientFxno { get; set; }
        public string? ClientEmail { get; set; }
        public string? ClientVatid { get; set; }
        public decimal? ClientCrdtLmit { get; set; }
        public string? ClientAdd1 { get; set; }
        public string? ClientAdd2 { get; set; }
        public string? ClientBadd1 { get; set; }
        public string? ClientBadd2 { get; set; }
        public string? ClientActv { get; set; }
        public string? ClientBlock { get; set; }
        public string? ClientType { get; set; }
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
        public string? ClientScustInfo { get; set; }

        public virtual ICollection<TvCommRateHistory> TvCommRateHistories { get; set; }
        public virtual ICollection<TvCommRate> TvCommRates { get; set; }
        public virtual ICollection<TvCprod> TvCprods { get; set; }
        public virtual ICollection<TvDelscdul> TvDelscdulDelscdulAgentNavigations { get; set; }
        public virtual ICollection<TvDelscdul> TvDelscdulDelscdulClientNavigations { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetlArcvlsdlAgentNavigations { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetlArcvlsdlClientNavigations { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscdulLsscdulAgentNavigations { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscdulLsscdulClientNavigations { get; set; }
        public virtual ICollection<TvMnrcvd> TvMnrcvdMnrcvdAgentNavigations { get; set; }
        public virtual ICollection<TvMnrcvd> TvMnrcvdMnrcvdClientNavigations { get; set; }
        public virtual ICollection<TvMnrcvm> TvMnrcvmMnrcvmAgentNavigations { get; set; }
        public virtual ICollection<TvMnrcvm> TvMnrcvmMnrcvmClientNavigations { get; set; }
        public virtual ICollection<TvPenbil> TvPenbilPenbilAgentNavigations { get; set; }
        public virtual ICollection<TvPenbil> TvPenbilPenbilClientNavigations { get; set; }
        public virtual ICollection<TvSchedule> TvScheduleScheduleAgentNavigations { get; set; }
        public virtual ICollection<TvSchedule> TvScheduleScheduleClientNavigations { get; set; }
        public virtual ICollection<TvSpblm> TvSpblmSpblmAgentNavigations { get; set; }
        public virtual ICollection<TvSpblm> TvSpblmSpblmClientNavigations { get; set; }
        public virtual ICollection<TvSprod> TvSprodSprodAgentNavigations { get; set; }
        public virtual ICollection<TvSprod> TvSprodSprodClientNavigations { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsdWrklsdAgentNavigations { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsdWrklsdClientNavigations { get; set; }
        public virtual ICollection<TvWrksdlMaster> TvWrksdlMasterWrksdlAgentNavigations { get; set; }
        public virtual ICollection<TvWrksdlMaster> TvWrksdlMasterWrksdlClientNavigations { get; set; }
    }
}
