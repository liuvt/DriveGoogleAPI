using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; } = null!;
        public string BlogDes { get; set; } = null!;
        public int BlogImageId { get; set; }
        public int BlogDateId { get; set; }
        public string BlogText { get; set; } = null!;
        public int BlogAuthorUserId { get; set; }
    }
}
