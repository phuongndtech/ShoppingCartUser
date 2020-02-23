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
    public class ProductServices : IProductServices
    {
        private readonly MyConfigure _configure;
        private readonly HttpClient _client;

        public ProductServices(HttpClient client, IOptions<MyConfigure> configure)
        {
            _client = client;
            _configure = configure.Value;
        }

        public async Task<List<ProductResponseModel>> GetProductByBrand(int brandId)
        {
            var httpResponse = await _client.GetAsync($"{_configure.Url}Product/BrandId?BrandId={brandId}");
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
            var items = JsonSerializer.Deserialize<List<ProductResponseModel>>(content, options);
            return items;
        }

        public async Task<ProductResponseModel> GetProductById(int id)
        {
            var httpResponse = await _client.GetAsync($"{_configure.Url}Product/Id?id={id}");
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
            var items = JsonSerializer.Deserialize<ProductResponseModel>(content, options);
            return items;
        }

        public async Task<List<ProductResponseModel>> GetProductHot()
        {

            var httpResponse = await _client.GetAsync($"{_configure.Url}Product/GetProductHot");
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
            var items = JsonSerializer.Deserialize<List<ProductResponseModel>>(content, options);
            return items;
        }

        public async Task<IEnumerable<ProductResponseModel>> SearchProduct(string name)
        {
            var httpResponse = await _client.GetAsync($"{_configure.Url}Product/Name?name={name}");
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
            var items = JsonSerializer.Deserialize<IEnumerable<ProductResponseModel>>(content, options);
            return items;
        }
    }
}