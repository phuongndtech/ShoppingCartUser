using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Respository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.ViewComponents
{
    [ViewComponent(Name = "BrandList")]
    public class BrandList : ViewComponent
    {
        private readonly IBrand _brand;
        private readonly IMapper _mapper;
        public BrandList(IBrand brand, IMapper mapper)
        {
            _brand = brand;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _brand.GetBrands();
            List<BrandViewModel> viewModels = _mapper.Map<List<BrandViewModel>>(items);
            return View(viewModels);
        }
    }
}