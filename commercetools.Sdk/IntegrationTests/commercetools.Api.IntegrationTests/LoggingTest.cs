using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit;
using ProjectApiRoot = commercetools.Sdk.Api.Client.ProjectApiRoot;

namespace commercetools.Api.IntegrationTests;

public class LoggingTest
{
    [Fact]
    public async void CustomLogger()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();
            
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter("System.Net.Http.HttpClient", LogLevel.None) // disable HTTP client default logging
                .AddProvider(new InMemoryLoggerProvider());
        });
        var s = new ServiceCollection();
        s.AddSingleton(loggerFactory);
        s.UseCommercetoolsApi(configuration, "Client");
        s.AddSingleton<ILoggerHandlerFactory, CustomLoggerHandlerFactory>();
        var p = s.BuildServiceProvider();

        var apiRoot = p.GetService<ProjectApiRoot>();
        InMemoryLogger.Clear();
        
        await apiRoot.Get().ExecuteAsync();
            
        var messages = InMemoryLogger.GetLogMessages();
        Assert.Equal("GET https://api.europe-west1.gcp.commercetools.com/test-php-dev-integration-1", messages.TrimEnd());
    }
    
    public class CustomLoggerHandler : DelegatingHandler
    {
        private readonly ILogger logger;

        public CustomLoggerHandler(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger("test");
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Send the request without logging the request details
            logger.Log(LogLevel.Information,   "{method} {uri}", request.Method.Method, request.RequestUri?.AbsoluteUri);
            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }
    
    class CustomLoggerHandlerFactory: ILoggerHandlerFactory
    {
        private readonly ILoggerFactory loggerFactory;

        public CustomLoggerHandlerFactory(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public DelegatingHandler Create()
        {
            return new CustomLoggerHandler(loggerFactory);
        }
    }
}

