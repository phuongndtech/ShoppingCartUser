using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models.Bussiness;
using ShoppingCartWeb.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name = "ProductCategoryList")]
    public class ProductCategoryList:ViewComponent
    {
        private readonly IProductCategory _productCategory;
        private readonly IMapper _mapper;
        public ProductCategoryList(IProductCategory productCategory, IMapper mapper)
        {
            _productCategory = productCategory;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync(int categoryId)
        {
            var items = await _productCategory.GetProductCategories(categoryId);
            List<ProductCategoryViewModel> viewModels = _mapper.Map<List<ProductCategoryViewModel>>(items);
            return View(viewModels);
        }
    }
}
