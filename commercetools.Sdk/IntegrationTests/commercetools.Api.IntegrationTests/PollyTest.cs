using System;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;
using Xunit;

namespace commercetools.Api.IntegrationTests
{
    public class PollyTest
    {
        [Fact]
        public async Task polly()
        {
            var services = new ServiceCollection();
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();


            var registry = services.AddPolicyRegistry();
            var retryPolicy = HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                .Or<TimeoutRejectedException>()
                .RetryAsync(3, onRetry: (exception, retryCount, context) =>
                {
                    // logging here
                });
            registry.Add("retryPolicy", retryPolicy);

            var timeOutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(60));
            registry.Add("timeoutPolicy", timeOutPolicy);

            var queuePolicy = Policy.Bulkhead(20);
            registry.Add("queuePolicy", queuePolicy);
            
            services.UseCommercetoolsApi(configuration, "Client")
                .AddPolicyHandlerFromRegistry("retryPolicy")
                .AddPolicyHandlerFromRegistry("timeoutPolicy")
                .AddPolicyHandlerFromRegistry("queuePolicy");
        }
    }
}