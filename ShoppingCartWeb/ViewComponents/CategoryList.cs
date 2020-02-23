using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Bussiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name = "CategoryList")]
    public class CategoryList:ViewComponent
    {
        private readonly ICategory _category;
        private readonly IMapper _mapper;

        public CategoryList(ICategory category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _category.GetCategories();
            List<CategoryViewModel> viewModels = _mapper.Map<List<CategoryViewModel>>(items);
            return View(viewModels);
        }
    }
}