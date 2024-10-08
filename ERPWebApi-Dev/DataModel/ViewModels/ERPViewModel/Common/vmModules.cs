using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
   public class vmModules
    {
        public int? pageNumber { get; set; }
        public int? pageSize { get; set; }
        public int? IsPaging { get; set; }
        public int Id { get; set; }
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
    }
}
