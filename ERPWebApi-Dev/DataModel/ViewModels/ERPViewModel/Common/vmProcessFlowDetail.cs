//using DataModels.EntityModels.ERPModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public partial class vmProcessFlowDetail
    {
        public string processFlowDetailId { get; set; }
        public string processFlowId { get; set; }
        public string processTypeId { get; set; }
        public string categoryId { get; set; }
        public string userId { get; set; }
        public int sequences { get; set; }
        public bool isActive { get; set; }
    }
}
