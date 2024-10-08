using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Business
{
    public partial class vmTermsCondition
    {
        public string termsConditionId { get; set; }
        public string quotationId { get; set; }
        public string termsConditions { get; set; }
        public decimal? slNumber { get; set; }
        public string tcOid { get; set; }        
        public bool isDelete { get; set; }
        public bool isActive { get; set; }

    }
}
