using Microsoft.CodeAnalysis.Options;
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
    public class BrandServices : IBrandServices
    {
        private readonly MyConfigure _configure;
        private readonly HttpClient _client;
        public BrandServices(HttpClient client, IOptions<MyConfigure> configure)
        {
            _client = client;
            _configure = configure.Value;
        }

        public Task<BrandResponseModel> GetBrandDetails()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BrandResponseModel>> GetBrands()
        {
            var httpResponse = await _client.GetAsync($"{_configure.Url}brand");
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
            var brandItem = JsonSerializer.Deserialize<IEnumerable<BrandResponseModel>>(content,options);
            return brandItem;
        }
    }
}