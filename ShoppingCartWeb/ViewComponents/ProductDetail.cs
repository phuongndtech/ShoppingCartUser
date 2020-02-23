using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Bussiness;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name ="ProductDetail")]
    public class ProductDetail:ViewComponent
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductDetail(IProduct product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var items = await _product.GetProductById(id);
            ProductViewModel viewModels = _mapper.Map<ProductViewModel>(items);
            return View(viewModels);
        }
    }
}
