using System.Text.Json.Serialization;

namespace ShoppingCartWeb.Models.ResponseModels
{
    public class BrandResponseModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonIgnore]
        public string Message { get; set; }
    }
}