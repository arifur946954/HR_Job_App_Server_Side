using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Business
{
    public partial class vmProcessTransaction
    {
        public string transactionId { get; set; }
        public string transactionDetailId { get; set; }
        public string quotationId { get; set; }
        public string categoryId { get; set; }        
        public string processFlowId { get; set; }
        public string processFlowDetailId { get; set; }
        public string processTypeId { get; set; }
        public int sequences { get; set; }
        public string fromUserId { get; set; }
        public string toUserId { get; set; }
        public string userId { get; set; }        
        public bool isApproved { get; set; }
        public bool isDeclined { get; set; }
        public bool isFailed { get; set; }
        public string comment { get; set; }

    }
}
