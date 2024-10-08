using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvHour
    {
        public TvHour()
        {
            TvBillds = new HashSet<TvBilld>();
            TvBillspBillspHour2Navigations = new HashSet<TvBillsp>();
            TvBillspBillspHourNavigations = new HashSet<TvBillsp>();
            TvCommRateHistories = new HashSet<TvCommRateHistory>();
            TvCommRates = new HashSet<TvCommRate>();
            TvDelscdulMasters = new HashSet<TvDelscdulMaster>();
            TvDelscduls = new HashSet<TvDelscdul>();
            TvLscdlarcvDetlArcvlsdlHour2Navigations = new HashSet<TvLscdlarcvDetl>();
            TvLscdlarcvDetlArcvlsdlHourNavigations = new HashSet<TvLscdlarcvDetl>();
            TvLscdlarcvMasters = new HashSet<TvLscdlarcvMaster>();
            TvLsscdulLsscdulHour2Navigations = new HashSet<TvLsscdul>();
            TvLsscdulLsscdulHourNavigations = new HashSet<TvLsscdul>();
            TvLsscdulMasters = new HashSet<TvLsscdulMaster>();
            TvPenbils = new HashSet<TvPenbil>();
            TvProgms = new HashSet<TvProgm>();
            TvScheduleMasters = new HashSet<TvScheduleMaster>();
            TvSchedules = new HashSet<TvSchedule>();
            TvSpblds = new HashSet<TvSpbld>();
            TvWrklsdMasters = new HashSet<TvWrklsdMaster>();
            TvWrklsdWrklsdHour2Navigations = new HashSet<TvWrklsd>();
            TvWrklsdWrklsdHourNavigations = new HashSet<TvWrklsd>();
            TvWrkords = new HashSet<TvWrkord>();
        }

        public string Oid { get; set; } = null!;
        public string HourText { get; set; } = null!;
        public string HourName { get; set; } = null!;
        public string? HourFtime { get; set; }
        public string? HourTtime { get; set; }
        public string? HourActv { get; set; }
        public string? HourType { get; set; }
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

        public virtual ICollection<TvBilld> TvBillds { get; set; }
        public virtual ICollection<TvBillsp> TvBillspBillspHour2Navigations { get; set; }
        public virtual ICollection<TvBillsp> TvBillspBillspHourNavigations { get; set; }
        public virtual ICollection<TvCommRateHistory> TvCommRateHistories { get; set; }
        public virtual ICollection<TvCommRate> TvCommRates { get; set; }
        public virtual ICollection<TvDelscdulMaster> TvDelscdulMasters { get; set; }
        public virtual ICollection<TvDelscdul> TvDelscduls { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetlArcvlsdlHour2Navigations { get; set; }
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetlArcvlsdlHourNavigations { get; set; }
        public virtual ICollection<TvLscdlarcvMaster> TvLscdlarcvMasters { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscdulLsscdulHour2Navigations { get; set; }
        public virtual ICollection<TvLsscdul> TvLsscdulLsscdulHourNavigations { get; set; }
        public virtual ICollection<TvLsscdulMaster> TvLsscdulMasters { get; set; }
        public virtual ICollection<TvPenbil> TvPenbils { get; set; }
        public virtual ICollection<TvProgm> TvProgms { get; set; }
        public virtual ICollection<TvScheduleMaster> TvScheduleMasters { get; set; }
        public virtual ICollection<TvSchedule> TvSchedules { get; set; }
        public virtual ICollection<TvSpbld> TvSpblds { get; set; }
        public virtual ICollection<TvWrklsdMaster> TvWrklsdMasters { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsdWrklsdHour2Navigations { get; set; }
        public virtual ICollection<TvWrklsd> TvWrklsdWrklsdHourNavigations { get; set; }
        public virtual ICollection<TvWrkord> TvWrkords { get; set; }
    }
}
