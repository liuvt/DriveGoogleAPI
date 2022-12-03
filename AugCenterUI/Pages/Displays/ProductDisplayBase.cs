using AugCenterModel.Models;
using Microsoft.AspNetCore.Components;

namespace AugCenterUI.Pages.Displays
{
    public class ProductDisplayBase: ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
