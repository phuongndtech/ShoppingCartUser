using AutoMapper;
using ShoppingCartWeb.Models.ResponseModels;
using ShoppingCartWeb.Models.ViewModels;

namespace ShoppingCartWeb.Models.MapperProfiles
{
    public class ProductCategoryProfile:Profile
    {
        public ProductCategoryProfile()
        {

            CreateMap<ProductCategoryResponseModel, ProductCategoryViewModel>();
            CreateMap<ProductCategoryViewModel, ProductCategoryResponseModel>();
        }
    }
}
