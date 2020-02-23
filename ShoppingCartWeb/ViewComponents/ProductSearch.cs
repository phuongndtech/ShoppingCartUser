using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name ="ProductSearch")]
    public class ProductSearch:ViewComponent
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductSearch(IProduct product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            var items = await _product.SearchProduct(name);
            List<ProductViewModel> viewModels = _mapper.Map<List<ProductViewModel>>(items);
            return View(viewModels);
        }
    }
}
