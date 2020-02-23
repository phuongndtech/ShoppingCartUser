using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShoppingCartWeb.Models;
using ShoppingCartWeb.Models.Bussiness;
using ShoppingCartWeb.Models.Configurations;
using ShoppingCartWeb.Models.Respository;
using ShoppingCartWeb.Services.Implement;
using ShoppingCartWeb.Services.IServices;

namespace ShoppingCartWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IBrandServices, BrandServices>();
            services.AddHttpClient<IProductServices, ProductServices>();
            services.AddHttpClient<ICategoryServices, CategoryServices>();
            services.AddHttpClient<IProductCategoryServices, ProductCategoryServices>();
            services.AddHttpClient<IUserServices, UserServices>();
            services.AddTransient<IBrand, Brand>();
            services.AddTransient<IProduct, Product>();
            services.AddTransient<ICategory, Category>();
            services.AddTransient<IUser, User>();
            services.AddTransient<IProductCategory, ProductCategory>();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();
            services.Configure<MyConfigure>(Configuration.GetSection("MyConfigure"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
