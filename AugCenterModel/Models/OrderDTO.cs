namespace AugCenterModel.Models
{
    public partial class OrderDTO
    {
        public int OrderId { get; set; }
        public int OrderUserId { get; set; }
        public float OrderAmount { get; set; }
        public string OrderShipName { get; set; } = null!;
        public string OrderShipAddress { get; set; } = null!;
        public string OrderShipAddress2 { get; set; } = null!;
        public string OrderCity { get; set; } = null!;
        public string OrderState { get; set; } = null!;
        public string OrderZip { get; set; } = null!;
        public string OrderCountry { get; set; } = null!;
        public string OrderPhone { get; set; } = null!;
        public string OrderFax { get; set; } = null!;
        public float OrderShipping { get; set; }
        public float OrderTax { get; set; }
        public string OrderEmail { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public bool OrderShipped { get; set; }
        public string? OrderTrackingNumber { get; set; }
    }
}
