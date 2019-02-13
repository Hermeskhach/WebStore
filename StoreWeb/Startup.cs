using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisnessLayer;
using BisnessLayer.BisnessModels;
using BisnessLayer.Interfaces;
using BisnessLayer.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreWeb.Models;

namespace StoreWeb
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration conf)
        {
            Configuration = conf;
            LayerConfig config = new LayerConfig(Configuration);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddTransient<IProductable, Product>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(routes =>
            {


                routes.MapRoute(
                        name: null,
                        template: "{category}/Page{productPage:int}",
                        defaults: new { controller = "Product", action = "ListProducts" });

                routes.MapRoute(
                       name: null,
                       template: "Page{productPage:int}",
                        defaults: new { controller = "Product", action = "ListProducts", productPage = 1 });


                routes.MapRoute(
                    name: null,
                    template: "{category}",
                     defaults: new { controller = "Product", action = "ListProducts", productPage = 1 });


                routes.MapRoute(
                        name: null,
                        template: "",
                        defaults: new { controller = "Product", action = "ListProducts", productPage = 1 });



                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });
        }
    }
}
