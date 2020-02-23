using Microsoft.Extensions.Options;
using ShoppingCartWeb.Models.Configurations;
using ShoppingCartWeb.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Services.IServices
{
    public class CategoryServices : ICategoryServices
    {
        private readonly MyConfigure _configure;
        private readonly HttpClient _client;

        public CategoryServices(HttpClient client, IOptions<MyConfigure> configure)
        {
            _client = client;
            _configure = configure.Value;
        }
        public async Task<IEnumerable<CategoryResponseModel>> GetCategories()
        {
            var httpResponse = await _client.GetAsync($"{_configure.Url}category");
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }
            var content = await httpResponse.Content.ReadAsStringAsync();
            var items = JsonSerializer.Deserialize<IEnumerable<CategoryResponseModel>>(content, options);
            return items;
        }

        public async Task<CategoryResponseModel> GetCategoryById()
        {
            throw new NotImplementedException();
        }
    }
}
