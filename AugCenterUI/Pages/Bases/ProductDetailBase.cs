using AugCenterModel.Models;
using AugCenterUI.Data.Interfaces;
using Microsoft.AspNetCore.Components;

namespace AugCenterUI.Pages.Bases
{
    public class ProductDetailBase : ComponentBase
    {
        [Parameter]
        public int id { get; set; }

        [Inject]
        public IProductService ProductService { get; set; }

        public ProductDTO Product { get; set; }

        public string ErrorMessage { get; set; }

        public string TittleN { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductService.GetProduct(id);
                TittleN = Product.ProductName;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

    }
}