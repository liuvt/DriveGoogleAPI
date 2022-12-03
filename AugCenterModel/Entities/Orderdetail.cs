using System;
using System.Collections.Generic;

namespace AugCenterModel.Entities
{
    public partial class Orderdetail
    {
        public int DetailId { get; set; }
        public int DetailOrderId { get; set; }
        public int DetailProductId { get; set; }
        public string DetailName { get; set; } = null!;
        public decimal DetailPrice { get; set; }
        public string DetailSku { get; set; } = null!;
        public int DetailQuantity { get; set; }
    }
}
