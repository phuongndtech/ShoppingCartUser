using ShoppingCartWeb.Models.ResponseModels;
using ShoppingCartWeb.Models.Respository;
using ShoppingCartWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models
{
    public class Brand:IBrand
    {
        private readonly IBrandServices _brandServices;
        public Brand(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }
        public async Task<List<BrandResponseModel>> GetBrands()
        {
            var brands = await _brandServices.GetBrands();
            return brands.ToList();
        }
    }
}
