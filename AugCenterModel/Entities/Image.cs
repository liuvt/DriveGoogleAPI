using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public string? ImageUrl1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public string? ImageUrl4 { get; set; }
        public string? ImageUrl5 { get; set; }
        public string ImageMain { get; set; } = null!;
    }
}
