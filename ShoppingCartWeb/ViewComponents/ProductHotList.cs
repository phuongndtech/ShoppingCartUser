using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name ="ProductHotList")]
    public class ProductHotList:ViewComponent
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;
        public ProductHotList(IProduct product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _product.GetProductHot();
            List<ProductViewModel> viewModels = _mapper.Map<List<ProductViewModel>>(items);
            return View(viewModels);
        }
    }
}