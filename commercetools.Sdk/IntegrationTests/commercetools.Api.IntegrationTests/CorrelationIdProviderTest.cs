using System;
using System.Linq;
using commercetools.Base.Client;
using commercetools.Base.Client.Middlewares;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.ImportApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Api.IntegrationTests;

public class CorrelationIdProviderTest
{
    [Fact]
    public async void TestCustomCorrelationId()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsApi(configuration, "Client");
        s.AddSingleton<ICorrelationIdProvider>(new TestCorrelationIdProvider());
        var p = s.BuildServiceProvider();
            
        var apiRoot = p.GetService<ProjectApiRoot>();

        var result = await apiRoot.Get().SendAsync();
        
        Assert.StartsWith("TestProvider/", result.HttpHeaders.GetValues(ApiHttpHeaders.X_CORRELATION_ID).First());
    }
    
    [Fact]
    public async void TestCorrelationId()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsApi(configuration, "Client");
        var p = s.BuildServiceProvider();
        var clientConfiguration = configuration.GetSection("Client").Get<ClientConfiguration>();
        var apiRoot = p.GetService<ProjectApiRoot>();

        var result = await apiRoot.Get().SendAsync();
        
        Assert.StartsWith(clientConfiguration.ProjectKey, result.HttpHeaders.GetValues(ApiHttpHeaders.X_CORRELATION_ID).First());
    }
    
    [Fact]
    public async void TestCorrelationIdPerRequest()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsApi(configuration, "Client");
        var p = s.BuildServiceProvider();
            
        var apiRoot = p.GetService<ProjectApiRoot>();

        ApiHttpHeaders headers = new ApiHttpHeaders();
        headers.AddHeader(ApiHttpHeaders.X_CORRELATION_ID, $"TestRequest/{Guid.NewGuid()}");
        var result = await apiRoot.Get().WithHeaders(headers).SendAsync();
        
        Assert.StartsWith("TestRequest/", result.HttpHeaders.GetValues(ApiHttpHeaders.X_CORRELATION_ID).First());
    }
    
    private class TestCorrelationIdProvider : ICorrelationIdProvider
    {
        public string CorrelationId => $"TestProvider/{Guid.NewGuid()}";
        public IClientConfiguration ClientConfiguration { get; set; }
    }
}