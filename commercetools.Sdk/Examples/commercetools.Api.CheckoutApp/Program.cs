using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OpenTelemetry.Logs;
using OpenTelemetry.Resources;

namespace commercetools.Api.CheckoutApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((context, logging) =>
                {
                    var configuration = context.Configuration;
                    var logExporter = configuration.GetValue("UseLogExporter", defaultValue: "console")!.ToLowerInvariant();

                    logging.ClearProviders();
                    logging.AddOpenTelemetry(options =>
                    {
                        // Note: See appsettings.json Logging:OpenTelemetry section for configuration.
                        var resourceBuilder = ResourceBuilder.CreateDefault();
                        Startup.ConfigureResource(resourceBuilder);
                        options.SetResourceBuilder(resourceBuilder);

                        switch (logExporter)
                        {
                            case "otlp":
                                options.AddOtlpExporter(otlpOptions =>
                                {
                                    // Use IConfiguration directly for Otlp exporter endpoint option.
                                    otlpOptions.Endpoint = new Uri(configuration.GetValue("Otlp:Endpoint", defaultValue: "http://localhost:4317")!);
                                });
                                break;
                            default:
                                options.AddConsoleExporter();
                                break;
                        }
                    });
                })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}