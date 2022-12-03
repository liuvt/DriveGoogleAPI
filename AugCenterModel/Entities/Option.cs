using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class Option
    {
        public int OptionId { get; set; }
        public int? OptionGroupId { get; set; }
        public string? OptionName { get; set; }
    }
}
