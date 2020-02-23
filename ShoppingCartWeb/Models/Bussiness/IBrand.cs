using ShoppingCartWeb.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models.Respository
{
    public interface IBrand
    {
        Task<List<BrandResponseModel>> GetBrands();
    }
}
