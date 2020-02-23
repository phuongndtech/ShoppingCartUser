using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult BrandVC()
        {
            return ViewComponent("BranList");
        }
    }
}