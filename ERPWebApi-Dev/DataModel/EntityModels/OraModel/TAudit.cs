using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TAudit
    {
        public string? ErrorId { get; set; }
        public string TabName { get; set; } = null!;
        public string ErrorCode { get; set; } = null!;
        public string ErrorMessage { get; set; } = null!;
        public DateTime Dt { get; set; }
        public string UserId { get; set; } = null!;
        public decimal? ErrorSolveStatus { get; set; }
        public string? ErrorSolvedBy { get; set; }
        public string CompId { get; set; } = null!;
        public string LocId { get; set; } = null!;
        public string? MacId { get; set; }
        public string? RefOid { get; set; }
    }
}
