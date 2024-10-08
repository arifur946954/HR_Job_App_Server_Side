using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Common
{
    public partial class CmnMenuPermission
    {
        public int PermissionId { get; set; }
        public bool? CanCreate { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanDelete { get; set; }
        public bool? CanView { get; set; }
        public int? MenuId { get; set; }
        public int? UserId { get; set; }
        public int? UserRole { get; set; }
        public int? UserType { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }

        public CmnMenu Menu { get; set; }
    }
}
