using ShoppingCartWeb.Models.ResponseModels;
using ShoppingCartWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models.Bussiness
{
    public class ProductCategory : IProductCategory
    {
        private readonly IProductCategoryServices _productCategoryServices;
        public ProductCategory(IProductCategoryServices productCategoryServices)
        {
            _productCategoryServices = productCategoryServices;
        }
        public async Task<List<ProductCategoryResponseModel>> GetProductCategories(int categoryId)
        {
            var items = await _productCategoryServices.GetProductCategoriesById(categoryId);
            return items.ToList();
        }
    }
}