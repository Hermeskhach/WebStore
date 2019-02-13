﻿using System;
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
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<LayerConfig>();
            services.AddTransient<IProductable, Product>();
            services.AddTransient<IProductRepository, ProductRepository>();
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
                    name: "pagination",
                    template: "Products/Page{productPage}",
                    defaults: new { Controller = "Product", action = "ListProducts" });

                routes.MapRoute(
                    name: "defaults",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
