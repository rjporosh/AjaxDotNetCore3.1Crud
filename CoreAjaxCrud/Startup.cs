using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoreAjaxCrud.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;

namespace CoreAjaxCrud
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

            services.AddControllersWithViews()
            //Uncomment for Newtonsoft. When commented, it uses the default System.Text.Json
            .AddNewtonsoftJson();
           // services.AddMvc();
            //  .AddJsonOptions(options => { 
            //                              }

            //);
            ////   services
            ////       .AddMvc();
            //         .AddJsonOptions(options => {
            //     // send back a ISO date
            //        var settings = options.SerializerSettings;
            //        settings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
            //     // dont mess with case of properties
            //        var resolver = options.SerializerSettings.ContractResolver as DefaultContractResolver;
            //    resolver.NamingStrategy = null;
            //});
            services.AddMvc()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                // Use the default property (Pascal) casing
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                //  options.S =
                // Configure a custom converter
                //     options.SerializerOptions.Converters.Add(new MyCustomJsonConverter());
               // options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            });

            services.AddEntityFrameworkSqlServer();

            services.AddDbContext<Context>
                       (options => options.UseSqlServer("data source =.; initial catalog = TestCOre;integrated security = true"));

            services.AddAntiforgery(options =>
                              options.HeaderName = "MY-XSRF-TOKEN");
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
