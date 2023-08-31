using System;
using System.Diagnostics.Metrics;
using commercetools.Api.CheckoutApp.Extensions;
using commercetools.Api.CheckoutApp.Services;
using commercetools.Base.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenTelemetry.Exporter;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using OpenTelemetry.Instrumentation.AspNetCore;
using OpenTelemetry.Metrics;

namespace commercetools.Api.CheckoutApp
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

            // Note: Switch between Zipkin/OTLP/Console by setting UseTracingExporter in appsettings.json.
            var tracingExporter = configuration.GetValue("UseTracingExporter", defaultValue: "console")!.ToLowerInvariant();

            // Note: Switch between Prometheus/OTLP/Console by setting UseMetricsExporter in appsettings.json.
            var metricsExporter = configuration.GetValue("UseMetricsExporter", defaultValue: "console")!.ToLowerInvariant();

            // Note: Switch between Explicit/Exponential by setting HistogramAggregation in appsettings.json
            var histogramAggregation = configuration.GetValue("HistogramAggregation", defaultValue: "explicit")!.ToLowerInvariant();

            services.AddSingleton<Instrumentation>();

            services.AddOpenTelemetry()
                .ConfigureResource(ConfigureResource)
                .WithTracing(builder =>
                    {
                        // Tracing

                        // Ensure the TracerProvider subscribes to any custom ActivitySources.
                        builder
                            .AddSource(Instrumentation.ActivitySourceName)
                            .SetSampler(new AlwaysOnSampler())
                            .AddHttpClientInstrumentation()
                            .AddAspNetCoreInstrumentation();

                        // Use IConfiguration binding for AspNetCore instrumentation options.
                        services.Configure<AspNetCoreInstrumentationOptions>(
                            configuration.GetSection("AspNetCoreInstrumentation"));

                        switch (tracingExporter)
                        {
                            case "zipkin":
                                builder.AddZipkinExporter();

                                builder.ConfigureServices(services =>
                                {
                                    // Use IConfiguration binding for Zipkin exporter options.
                                    services.Configure<ZipkinExporterOptions>(configuration.GetSection("Zipkin"));
                                });
                                break;

                            case "otlp":
                                builder.AddOtlpExporter(otlpOptions =>
                                {
                                    // Use IConfiguration directly for Otlp exporter endpoint option.
                                    otlpOptions.Endpoint = new Uri(configuration.GetValue("Otlp:Endpoint",
                                        defaultValue: "http://localhost:4317")!);
                                });
                                break;

                            default:
                                builder.AddConsoleExporter();
                                break;
                        }
                    }
                )
                .WithMetrics(builder =>
                {
                    // Metrics

                    // Ensure the MeterProvider subscribes to any custom Meters.
                    builder
                        .AddMeter(Instrumentation.MeterName)
                        .AddRuntimeInstrumentation()
                        .AddHttpClientInstrumentation()
                        .AddAspNetCoreInstrumentation();

                    switch (histogramAggregation)
                    {
                        case "exponential":
                            builder.AddView(instrument => instrument.GetType().GetGenericTypeDefinition() == typeof(Histogram<>)
                                ? new Base2ExponentialBucketHistogramConfiguration()
                                : null);
                            break;
                        default:
                            // Explicit bounds histogram is the default.
                            // No additional configuration necessary.
                            break;
                    }

                    switch (metricsExporter)
                    {
                        case "otlp":
                            builder.AddOtlpExporter(otlpOptions =>
                            {
                                // Use IConfiguration directly for Otlp exporter endpoint option.
                                otlpOptions.Endpoint = new Uri(configuration.GetValue("Otlp:Endpoint", defaultValue: "http://localhost:4317")!);
                            });
                            break;
                        default:
                            builder.AddConsoleExporter();
                            break;
                    }
                });
        }

        public static void ConfigureResource(ResourceBuilder r) => r.AddService(serviceName: "commercetools-checkout-demo", serviceVersion: typeof(Program).Assembly.GetName().Version?.ToString() ?? "unknown", serviceInstanceId: Environment.MachineName);

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