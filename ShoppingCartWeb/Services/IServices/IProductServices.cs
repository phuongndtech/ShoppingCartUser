using ShoppingCartWeb.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Services.IServices
{
    public interface IProductServices
    {
        Task<ProductResponseModel> GetProductById(int id);
        Task<List<ProductResponseModel>> GetProductByBrand(int brandId);
        Task<IEnumerable<ProductResponseModel>> SearchProduct(string name);
        Task<List<ProductResponseModel>> GetProductHot();
    }
}
