using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmMenues
    {
        public int id { get; set; }
        public int? menuId { get; set; }
        public int? parentId { get; set; }
        public int? subParentId { get; set; }
        public string menuName { get; set; }
        public string menuIcon { get; set; }
        public string menuPath { get; set; }
        public int? menuSequence { get; set; }
        public bool? isActive { get; set; }
        public bool? isSubparent { get; set; }
    }
}
