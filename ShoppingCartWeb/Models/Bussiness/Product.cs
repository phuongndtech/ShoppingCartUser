using ShoppingCartWeb.Models.ResponseModels;
using ShoppingCartWeb.Services.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models.Bussiness
{
    public class Product : IProduct
    {
        private readonly IProductServices _productServices;
        public Product(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public async Task<ProductResponseModel> GetProductById(int id)
        {
            var items = await _productServices.GetProductById(id);
            return items;
        }

        public async Task<List<ProductResponseModel>> GetProductByBrand(int brandId)
        {
            var items = await _productServices.GetProductByBrand(brandId);
            return items;
        }
        public async Task<List<ProductResponseModel>> GetProductHot()
        {
            var items = await _productServices.GetProductHot();
            return items;
        }
        public async Task<IEnumerable<ProductResponseModel>> SearchProduct(string name)
        {
            var items = await _productServices.SearchProduct(name);
            return items;
        }
    }
}