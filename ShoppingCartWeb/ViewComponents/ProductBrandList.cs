using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name= "ProductBrandList")]
    public class ProductBrandList:ViewComponent
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;
        public ProductBrandList(IProduct product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync(int brandId)
        {
            var items = await _product.GetProductByBrand(brandId);
            List<ProductViewModel> viewModels = _mapper.Map<List<ProductViewModel>>(items);
            return View(viewModels);
        }
    }
}
