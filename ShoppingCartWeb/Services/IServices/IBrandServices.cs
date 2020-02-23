using ShoppingCartWeb.Models.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Services.IServices
{
    public interface IBrandServices
    {
        Task<IEnumerable<BrandResponseModel>> GetBrands();
        Task<BrandResponseModel> GetBrandDetails();
    }
}