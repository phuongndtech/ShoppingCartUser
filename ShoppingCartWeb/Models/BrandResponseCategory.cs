using Newtonsoft.Json;
using ShoppingCartWeb.Models.ResponseModels;
using System.Collections.Generic;

namespace ShoppingCartWeb.Models
{
    public class BrandResponseCategory
    {
        [JsonProperty("brandId")]
        public int BrandId { get; set; }
        [JsonProperty("brandName")]
        public string BrandName { get; set; }
        [JsonProperty("products")]
        public List<ProductResponseModel> Products { get; set; }
    }
}
