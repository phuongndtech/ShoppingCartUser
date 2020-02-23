using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Controllers
{
    public class ProductCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductCategoryVC(int id)
        {
            return ViewComponent("ProductCategoryList", new { categoryId = id});
        }

        public IActionResult GetProductByBrand(int brandId)
        {
            return ViewComponent("ProductBrandList", new { brandId = brandId });
        }
    }
}