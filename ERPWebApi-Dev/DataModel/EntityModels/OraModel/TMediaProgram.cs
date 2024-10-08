using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TMediaProgram
    {
        public string Oid { get; set; } = null!;
        public string? ProgramTrno { get; set; }
        public string? ProgramName { get; set; }
        public string? ProgramBegin { get; set; }
        public string? ProgramEnd { get; set; }
        public string? ProgramBname { get; set; }
        public string? ProgramSname { get; set; }
        public string? Isactive { get; set; }
        public string? Iscancel { get; set; }
        public string? Createby { get; set; }
        public DateTime? Createon { get; set; }
        public string? Createpc { get; set; }
        public string? Updateby { get; set; }
        public DateTime? Updateon { get; set; }
        public string? Updatepc { get; set; }
    }
}
