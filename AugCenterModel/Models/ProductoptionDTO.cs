namespace AugCenterModel.Models
{
    public partial class ProductoptionDTO
    {
        public uint ProductOptionId { get; set; }
        public uint ProductId { get; set; }
        public uint OptionId { get; set; }
        public double? OptionPriceIncrement { get; set; }
        public int OptionGroupId { get; set; }
    }
}
