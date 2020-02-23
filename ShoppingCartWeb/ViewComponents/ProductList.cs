using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name ="ProductList")]
    public class ProductList:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}