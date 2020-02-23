using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryVC()
        {
            return ViewComponent("CategoryList");
        }
    }
}