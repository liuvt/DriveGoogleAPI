using AugCenterModel.Entities;
using AugCenterModel.Models;

namespace AugCenterModel.ConvertDTO
{
    public static class CvertProducts
    {
        //Convert Thêm Category vào trong Product và trả về một danh sách ProductDTO
        // Thêm "this" để không phải truyền tham số Products
        // Khi gọi hàm ConvertProductsToDo chỉ truyền duy nhất tham số Categories
        public static IEnumerable<ProductDTO> ConvertProductsToDo(this IEnumerable<Product> products,
                                                                      IEnumerable<Productcategory> productcategories)
        {
            return (from p in products
                    join c in productcategories
                    on p.ProductCategoryId equals c.CategoryId
                    select new ProductDTO
                    {
                        ProductId = p.ProductId,
                        ProductSku = p.ProductSku,
                        ProductName = p.ProductName,
                        ProductPrice = p.ProductPrice,
                        ProductCartDesc = p.ProductCartDesc,
                        ProductShortDesc = p.ProductShortDesc,
                        ProductLongDesc = p.ProductLongDesc,
                        ProductThumb = p.ProductThumb,
                        ProductImage = p.ProductImage,
                        ProductUpdateDate = p.ProductUpdateDate,
                        ProductStock = p.ProductStock,
                        ProductLive = p.ProductLive,
                        ProductUnlimited = p.ProductUnlimited,
                        ProductLocation = p.ProductLocation,
                        Productcategories = c
                    });
        }

        //Convert Thêm Category vào trong Product và trả về một ProductDTO
        // Thêm "this" để không phải truyền tham số Products
        // Khi gọi hàm ConvertProductsToDo chỉ truyền duy nhất tham số Categories
        public static ProductDTO ConvertProductsToDo(this Product products,
                                                                      Productcategory productcategories)
        {
            return new ProductDTO
                    {
                        ProductId = products.ProductId,
                        ProductSku = products.ProductSku,
                        ProductName = products.ProductName,
                        ProductPrice = products.ProductPrice,
                        ProductCartDesc = products.ProductCartDesc,
                        ProductShortDesc = products.ProductShortDesc,
                        ProductLongDesc = products.ProductLongDesc,
                        ProductThumb = products.ProductThumb,
                        ProductImage = products.ProductImage,
                        ProductUpdateDate = products.ProductUpdateDate,
                        ProductStock = products.ProductStock,
                        ProductLive = products.ProductLive,
                        ProductUnlimited = products.ProductUnlimited,
                        ProductLocation = products.ProductLocation,
                        Productcategories = productcategories
                    };
        }
    }
}
