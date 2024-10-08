//using DataModels.EntityModels.ERPModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels.ERPViewModel.Common
{
    public class vmCmnUser //: CmnUser
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public bool? IsLocked { get; set; }
        public string TypeName { get; set; }
        public string WeekDay { get; set; }
        public string ShiftType { get; set; }
        public string ShiftCat { get; set; }
        public int? ShiftId { get; set; }

        public string[] typeList { get; set; }

        #region properties for employee
        public bool? IsLineManager { get; set; }
        public int? LineManagerId { get; set; }
        #endregion
    }
}
