using AutoMapper;
using ShoppingCartWeb.Models.ResponseModels;

namespace ShoppingCartWeb.Models.MapperProfiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductViewModel, ProductResponseModel>();
            CreateMap<ProductResponseModel, ProductViewModel>();
        }
    }
}