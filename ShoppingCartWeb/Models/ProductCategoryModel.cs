using Newtonsoft.Json;

namespace ShoppingCartWeb.Models
{
    public class ProductCategoryModel
    {
        [JsonProperty("productId")]
        public int ProductId { get; set; }
        [JsonProperty("categoryid")]
        public int CategoryId { get; set; }
        [JsonProperty("productName")]
        public string ProductName { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("imageFile")]
        public string ImageFile { get; set; }
        [JsonProperty("brandName")]
        public string BrandName { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }
}