using System;
using System.Collections.Generic;

#nullable disable

namespace DataModel.EntityModels.OraModel
{
    public partial class TApprovalMatrix
    {
        public string Oid { get; set; }
        public string Menuid { get; set; }
        public string Menuname { get; set; }
        public string Preparedby { get; set; }
        public string Verifiedby { get; set; }
        public string Approvedby { get; set; }
        public string Isactive { get; set; }
        public string Verifyname { get; set; }
        public string Approvename { get; set; }
        public string Preparename { get; set; }
    }
}
