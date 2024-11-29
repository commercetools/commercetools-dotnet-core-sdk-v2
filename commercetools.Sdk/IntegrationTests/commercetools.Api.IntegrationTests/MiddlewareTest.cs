using System.Collections.Generic;
using commercetools.Base.Client;
using commercetools.Base.Client.Middlewares;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Api.IntegrationTests;

public class MiddlewareTest
{
    [Fact]
    public async void not_found_middleware_stream_client()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsApi(configuration, "Client", options: new ClientOptions() { ReadResponseAsStream = true }, middlewares: new List<DelegatingMiddleware>()
        {
            new NotFoundMiddleware()
        });
        var p = s.BuildServiceProvider();

        var apiConfig = configuration.GetSection("Client").Get<ClientConfiguration>();
        var apiRoot = p.GetService<ProjectApiRoot>();

        Assert.Equal("Client", apiRoot.ClientName);
        var category = await apiRoot.Categories().WithKey("unknown-key").Get().ExecuteAsync().ConfigureAwait(false);

        Assert.Null(category);
    }

    [Fact]
    public async void not_found_middleware_string_client()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsApi(configuration, "Client", options: new ClientOptions() { ReadResponseAsStream = false }, middlewares: new List<DelegatingMiddleware>()
        {
            new NotFoundMiddleware()
        });
        var p = s.BuildServiceProvider();

        var apiConfig = configuration.GetSection("Client").Get<ClientConfiguration>();
        var apiRoot = p.GetService<ProjectApiRoot>();

        Assert.Equal("Client", apiRoot.ClientName);
        var category = await apiRoot.Categories().WithKey("unknown-key").Get().ExecuteAsync().ConfigureAwait(false);

        Assert.Null(category);
    }

}