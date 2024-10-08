using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Business
{
    public class vmServiceHead
    {
        public string srvHeadId { get; set; }
        public string srvHeadCode { get; set; }
        public string srvHeadName { get; set; }
        public string srvHeadBName { get; set; }
        public string srvHeadSName { get; set; }
        public string srvHeadGroupId { get; set; }
        public string categoryId { get; set; }
        public bool? isActive { get; set; }
        public int? sl { get; set; }
        public bool ifExist { get; set; }
    }

    public class vmServiceHeadToJson
    {
        public string srvHeadId { get; set; }
        public string srvHeadCode { get; set; }
        public string srvHeadName { get; set; }
        public string srvHeadBName { get; set; }
        public string srvHeadSName { get; set; }
        public string srvHeadGroupId { get; set; }
        public string categoryId { get; set; }
        public bool? isActive { get; set; }
        public int? sl { get; set; }
    }
}
