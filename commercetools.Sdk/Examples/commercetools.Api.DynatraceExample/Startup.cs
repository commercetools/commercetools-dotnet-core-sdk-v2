using commercetools.Api.DynatraceExample.Extensions;
using commercetools.Api.DynatraceExample.Services;
using commercetools.Base.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace commercetools.Api.DynatraceExample
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
            var clientConfiguration = configuration.GetSection("SPA-Client").Get<ClientConfiguration>();
            Settings.ProjectKey = clientConfiguration.ProjectKey;
            Settings.DefaultCurrency = configuration.GetSection("DefaultCurrency").Value;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.UseCommercetoolsScopedClient(configuration, "SPA-Client");
            services.AddScoped<InCookiesStoreManager>();
            services.AddScoped<InSessionStoreManager>();
            services.AddScoped<CartServices>();
            services.AddScoped<ProductServices>();
            services.AddScoped<MeServices>();
            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
            });
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddHttpContextAccessor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}