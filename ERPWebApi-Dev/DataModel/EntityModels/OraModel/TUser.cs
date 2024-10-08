using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TUser
    {
        public TUser()
        {
            TUserMenus = new HashSet<TUserMenu>();
        }

        public string Oid { get; set; } = null!;
        public string UserText { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserSname { get; set; } = null!;
        public string? UserPass { get; set; }
        public string UserType { get; set; } = null!;
        public string? UserStat { get; set; }
        public string? UserPrnt { get; set; }
        public string? UserBkdt { get; set; }
        public string? UserWeb { get; set; }
        public string? UserRpnt { get; set; }
        public string? UserRexp { get; set; }
        public string? UserSpcl { get; set; }
        public string UserEmail { get; set; } = null!;
        public string? Iuser { get; set; }
        public DateTime? Idat { get; set; }
        public string? Euser { get; set; }
        public DateTime? Edat { get; set; }
        public string? DeviceId { get; set; }

        public virtual ICollection<TUserMenu> TUserMenus { get; set; }
    }
}
