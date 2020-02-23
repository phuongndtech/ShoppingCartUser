using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShoppingCartWeb.Models.ResponseModels
{
    public class ProductCategoryResponseModel
    {
        [JsonProperty("brandResponses")]
        public List<BrandResponseCategory> BrandResponses { get; set; }
    }
}
