//using DataModels.EntityModels.ERPModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public partial class vmProcessFlow
    {
        public string processFlowId { get; set; }
        public string processFlowCode { get; set; }
        public string categoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
