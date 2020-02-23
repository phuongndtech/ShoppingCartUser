using ShoppingCartWeb.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Models.Bussiness
{
    public interface ICategory
    {
        Task<List<CategoryResponseModel>> GetCategories();
    }
}
