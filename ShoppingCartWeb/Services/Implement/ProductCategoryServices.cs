using Microsoft.Extensions.Options;
using ShoppingCartWeb.Models.Configurations;
using ShoppingCartWeb.Models.ResponseModels;
using ShoppingCartWeb.Services.IServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShoppingCartWeb.Services.Implement
{
    public class ProductCategoryServices : IProductCategoryServices
    {
        private readonly HttpClient _client;
        private readonly MyConfigure _configure;
        public ProductCategoryServices(HttpClient client, IOptions<MyConfigure> configure)
        {
            _client = client;
            _configure = configure.Value;
        }
        public async Task<IEnumerable<ProductCategoryResponseModel>> GetProductCategoriesById(int categoryId)
        {
            var httpResponse = await _client.GetAsync($"{_configure.Url}ProductCategory/categoryId/?categoryId={categoryId}");
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
            var items = JsonSerializer.Deserialize<IEnumerable<ProductCategoryResponseModel>>(content, options);
            return items;
        }
    }
}