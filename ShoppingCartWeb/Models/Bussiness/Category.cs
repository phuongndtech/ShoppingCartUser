using ShoppingCartWeb.Models.ResponseModels;
using ShoppingCartWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models.Bussiness
{
    public class Category : ICategory
    {
        private readonly ICategoryServices _categoryServices;
        public Category(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public async Task<List<CategoryResponseModel>> GetCategories()
        {
            var res = await _categoryServices.GetCategories();
            return res.ToList();
        }
    }
}
