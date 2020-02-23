using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetailVC(int id)
        {
            return ViewComponent("ProductDetail", new { id= id});
        }

        public IActionResult SearchVC(string name)
        {
            return ViewComponent("ProductSearch", new { name = name });
        }
        
        public IActionResult ProductHotListVC()
        {
            return ViewComponent("ProductHotList");
        }
    }
}