using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class Productoption
    {
        public uint ProductOptionId { get; set; }
        public uint ProductId { get; set; }
        public uint OptionId { get; set; }
        public double? OptionPriceIncrement { get; set; }
        public int OptionGroupId { get; set; }
    }
}
