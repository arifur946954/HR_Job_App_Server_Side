﻿using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TvLscdlarcvMaster
    {
        public TvLscdlarcvMaster()
        {
            TvLscdlarcvDetls = new HashSet<TvLscdlarcvDetl>();
        }

        public string Oid { get; set; } = null!;
        public string ArcvlssmText { get; set; } = null!;
        public DateTime? ArcvlssmCdate { get; set; }
        public DateTime? ArcvlssmSdate { get; set; }
        public string ArcvlssmHour { get; set; } = null!;
        public string? ArcvlssmPosf { get; set; }
        public string? ArcvlssmPntflg { get; set; }
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

        public virtual TvHour ArcvlssmHourNavigation { get; set; } = null!;
        public virtual ICollection<TvLscdlarcvDetl> TvLscdlarcvDetls { get; set; }
    }
}
