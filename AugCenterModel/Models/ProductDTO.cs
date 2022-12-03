using AugCenterModel.Entities;

namespace AugCenterModel.Models
{
    public partial class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductSku { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public string ProductCartDesc { get; set; } = null!;
        public string ProductShortDesc { get; set; } = null!;
        public string ProductLongDesc { get; set; } = null!;
        public string ProductThumb { get; set; } = null!;
        public string ProductImage { get; set; } = null!;
        public DateTime ProductUpdateDate { get; set; }
        public float? ProductStock { get; set; }
        public bool? ProductLive { get; set; }
        public bool? ProductUnlimited { get; set; }
        public string? ProductLocation { get; set; }
        public Productcategory? Productcategories { get; set; }
    }
}
