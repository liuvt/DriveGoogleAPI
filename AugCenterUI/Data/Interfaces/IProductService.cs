using AugCenterModel.Models;

namespace AugCenterUI.Data.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProduct(int id);

    }
}

