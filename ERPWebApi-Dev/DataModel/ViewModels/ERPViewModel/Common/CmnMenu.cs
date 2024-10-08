using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Common
{
    public partial class CmnMenu
    {
        public CmnMenu()
        {
            CmnMenuPermission = new HashSet<CmnMenuPermission>();
        }

        public int MenuId { get; set; }
        public int? ModuleId { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public int? ParentId { get; set; }
        public bool? IsSubParent { get; set; }
        public int? SubParentId { get; set; }
        public string MenuIcon { get; set; }
        public string MenuPath { get; set; }
        public int? MenuSequence { get; set; }
        public bool? IsActive { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }

        public CmnModule Module { get; set; }
        public ICollection<CmnMenuPermission> CmnMenuPermission { get; set; }
    }
}
