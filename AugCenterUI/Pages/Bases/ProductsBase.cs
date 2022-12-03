using AugCenterModel.Models;
using AugCenterUI.Data.Interfaces;
using Microsoft.AspNetCore.Components;

namespace AugCenterUI.Pages.Bases
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService? ProductService { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetProducts();
        }

        protected IEnumerable<IGrouping<int, ProductDTO>> GetGroupedProductsByCaterogy()
        {
            //LinQuery -> Nhóm danh sách sản phẩm theo CategoryID
            return from product in Products
                   group product by product.Productcategories.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProductDTO> groupedProductCategory)
        {
            return groupedProductCategory.FirstOrDefault(pg => pg.Productcategories.CategoryId == groupedProductCategory.Key)
                                                                                                    .Productcategories.CategoryName;
        }
    }
}