using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmRoleMenu
    {
        //public int? ModuleID { get; set; }
        //public string ModuleName { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
        public int? ParentID { get; set; }
        public string ParentName { get; set; }
        public string MenuIcon { get; set; }
        public string MenuPath { get; set; }
        public int? MenuSequence { get; set; }
        public int? RoleID { get; set; }
        public string RoleName { get; set; }
        public string SubParentName { get; set; }
        public int? SubParentID { get; set; }
        public bool? IsSubParent { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsView { get; set; }
        public bool? IsInsert { get; set; }
        public bool? IsUpdate { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsEdit { get; set; }
        public bool? HasChild { get; set; }
        public int? recordsTotal { get; set; }
        public int? CompanyID { get; set; }
    }
}
