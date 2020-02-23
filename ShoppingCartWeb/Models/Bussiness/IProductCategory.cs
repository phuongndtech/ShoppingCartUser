using ShoppingCartWeb.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models.Bussiness
{
    public interface IProductCategory
    {
        Task<List<ProductCategoryResponseModel>> GetProductCategories(int id);
    }
}
