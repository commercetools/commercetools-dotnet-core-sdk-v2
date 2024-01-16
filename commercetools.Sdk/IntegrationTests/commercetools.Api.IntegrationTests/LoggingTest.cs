using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
        var clientConfiguration = configuration.GetSection("Client").Get<ClientConfiguration>();
        var loggerClientConf = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string>()
            {
                { "LoggerClient:ClientId", clientConfiguration.ClientId},
                { "LoggerClient:ClientSecret", clientConfiguration.ClientSecret},
                { "LoggerClient:ProjectKey", clientConfiguration.ProjectKey},
            })
            .Build();
        var logger = new TestLogger();
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter("System.Net.Http.HttpClient", LogLevel.None) // disable HTTP client default logging
                .AddProvider(new TestLoggerProvider(logger));
        });
        var s = new ServiceCollection();
        s.AddSingleton(loggerFactory);
        s.UseCommercetoolsApi(loggerClientConf, "LoggerClient");
        s.AddSingleton<ILoggerHandlerFactory, CustomLoggerHandlerFactory>();
        var p = s.BuildServiceProvider();

        var apiRoot = p.GetService<ProjectApiRoot>();
        
        await apiRoot.Get().ExecuteAsync();
            
        var messages = logger.GetLogMessages();
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

    class TestLoggerProvider : ILoggerProvider
    {
        private readonly ILogger _logger;

        public TestLoggerProvider(ILogger logger)
        {
            _logger = logger;
        }

        public void Dispose()
        {
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _logger;
        }
    }

    class TestLogger : ILogger
    {
        private ConcurrentQueue<string> LogMessages { get; set; }

        public void Log<TState>(
            LogLevel logLevel, EventId eventId,
            TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            if (LogMessages == null)
            {
                LogMessages = new ConcurrentQueue<string>();
            }
            if (formatter != null)
            {
                LogMessages.Enqueue((formatter(state, exception)));
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public void Clear()
        {
            LogMessages?.Clear();
        }

        public string GetLogMessages()
        {
            if (LogMessages == null)
                return "";

            var stringBuilder = new StringBuilder();
            foreach (var item in LogMessages)
            {
                stringBuilder.AppendLine(item);
            }

            return stringBuilder.ToString();
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

