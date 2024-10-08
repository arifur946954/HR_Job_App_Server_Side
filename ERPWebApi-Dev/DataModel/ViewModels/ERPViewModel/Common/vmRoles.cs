using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmRoles
    {
        public int? UserRoleId { get; set; }
        public string UserId { get; set; }
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Remarks { get; set; }
        public string RoleCode { get; set; }
        public bool IsActive { get; set; }
    }    
}
