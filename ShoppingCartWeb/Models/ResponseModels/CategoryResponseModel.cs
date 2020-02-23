using Newtonsoft.Json;

namespace ShoppingCartWeb.Models.ResponseModels
{
    public class CategoryResponseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonIgnore]
        public string Messages { get; set; }
    }
}
