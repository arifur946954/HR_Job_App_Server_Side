using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.ViewModels
{
    public class vmCmnDocument
    {
        public int? DocumentId { get; set; }
        public int? ReferenceId { get; set; }
        public string OriginalDocName { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public long DocumentSize { get; set; }
        public string BasePath { get; set; }
        public string DocumentPath { get; set; }
        public string VirtualPath { get; set; }
        public string DocumentFullPath { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public string CreateBy { get; set; }
    }    
}
