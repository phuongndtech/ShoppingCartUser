using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCartWeb.Controllers
{
    public class BestDealController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}