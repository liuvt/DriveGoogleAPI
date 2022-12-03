namespace AugCenterModel.Models
{
    public partial class OrderdetailDTO
    {
        public int DetailId { get; set; }
        public int DetailOrderId { get; set; }
        public int DetailProductId { get; set; }
        public string DetailName { get; set; } = null!;
        public float DetailPrice { get; set; }
        public string DetailSku { get; set; } = null!;
        public int DetailQuantity { get; set; }
    }
}
