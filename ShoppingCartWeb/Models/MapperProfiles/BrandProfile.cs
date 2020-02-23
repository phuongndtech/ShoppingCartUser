using AutoMapper;
using ShoppingCartWeb.Models.ResponseModels;

namespace ShoppingCartWeb.Models.MapperProfiles
{
    public class BrandProfile:Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandResponseModel, BrandViewModel>();
            CreateMap<BrandViewModel, BrandResponseModel>();
        }
    }
}
