using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class Datetime
    {
        public int DateTimeId { get; set; }
        public DateTime DateTimeCreateAt { get; set; }
        public DateTime? DateTimeUpdateAt { get; set; }
        public DateTime? DateTimePublishAt { get; set; }
    }
}
