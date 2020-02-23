using ShoppingCartWeb.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Services.IServices
{
    public interface IProductCategoryServices
    {
        Task<IEnumerable<ProductCategoryResponseModel>> GetProductCategoriesById(int categoryId);
    }
}