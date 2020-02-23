using ShoppingCartWeb.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Services.IServices
{
    public interface ICategoryServices
    {
        Task<IEnumerable<CategoryResponseModel>> GetCategories();
        Task<CategoryResponseModel> GetCategoryById();
    }
}
