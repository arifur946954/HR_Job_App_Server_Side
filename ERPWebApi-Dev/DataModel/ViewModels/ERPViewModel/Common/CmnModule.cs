using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Common
{
    public partial class CmnModule
    {
        public CmnModule()
        {
            CmnMenu = new HashSet<CmnMenu>();
        }

        public int ModuleId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }
        public string ModuleIcon { get; set; }
        public string ModuleColor { get; set; }
        public string ModulePath { get; set; }
        public int? ModuleSequence { get; set; }
        public bool? IsActive { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }

        public ICollection<CmnMenu> CmnMenu { get; set; }
    }
}
