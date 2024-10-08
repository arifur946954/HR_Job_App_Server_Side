using System;
using System.Collections.Generic;

namespace DataModel.EntityModels.OraModel
{
    public partial class TSbPhoteagraphy
    {
        public string Oid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Age { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Device { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageCategory { get; set; } = null!;
        public string ImageFileName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public string? ImageSize { get; set; }
        public string IsUpload { get; set; } = null!;
        public string IpAdd { get; set; } = null!;
        public DateTime Dt { get; set; }
        public DateTime Ts { get; set; }
    }
}
