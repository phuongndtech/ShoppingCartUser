using AutoMapper;
using ShoppingCartWeb.Models.ResponseModels;

namespace ShoppingCartWeb.Models.MapperProfiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryResponseModel, CategoryViewModel>();
            CreateMap<CategoryViewModel, CategoryResponseModel>();
        }
    }
}