using AugCenterUI.Data.Interfaces;
using AugCenterModel.Models;

namespace AugCenterUI.Data.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        //Get: api/Product with Categories
        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            try
            {
                var products = await this.httpClient.GetAsync($"api/Products");
                if (
                    products.IsSuccessStatusCode
                )
                {
                    if (products.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProductDTO>();
                    }
                    return await products.Content.ReadFromJsonAsync<IEnumerable<ProductDTO>>();
                }

                else
                {
                    var mess = await products.Content.ReadAsStringAsync();
                    throw new Exception(mess);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }


        //Get: api/Product/{id} with Categories
        public async Task<ProductDTO> GetProduct(int id)
        {
            try
            {
                var product = await httpClient.GetAsync($"api/Products/{id}");
                if (product.IsSuccessStatusCode)
                {
                    if (product.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ProductDTO);
                    }

                    return await product.Content.ReadFromJsonAsync<ProductDTO>();
                }
                else
                {
                    var mess = await product.Content.ReadAsStringAsync();
                    throw new Exception(mess);
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
    }
}
