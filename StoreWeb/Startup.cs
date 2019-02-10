using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BisnessLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            routes.MapRoute(
                name: "defaults",
            template: "{controller=Home}/{action=Index}/{id?}")
            );
        }
    }
}
