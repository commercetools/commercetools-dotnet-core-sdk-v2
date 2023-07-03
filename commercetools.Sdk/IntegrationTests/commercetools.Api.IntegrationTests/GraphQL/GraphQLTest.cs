using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using ZeroQL;

namespace commercetools.Api.IntegrationTests.GraphQL;

public class GraphQLTest
{

    [Fact]
    public async Task GraphQLQuery()
    {
        var configuration = new ConfigurationBuilder().
            AddJsonFile("appsettings.test.Development.json", true).
            AddEnvironmentVariables().
            AddUserSecrets<ServiceProviderFixture>().
            AddEnvironmentVariables("CTP_").
            Build();

        var s = new ServiceCollection();
        s.UseCommercetoolsApi(configuration, "Client");
        var provider = s.BuildServiceProvider();

        var c = provider.GetService<IClient>();

        var client = new ZeroQLClient(new CtpClientHandler(provider.GetService<IClient>()));
        
        
        var t = await client.Query( o => o.Products(selector: r => new { results = r.Results(product => new { product.Id }) }));

        
        Assert.NotNull(t);
    }

    class CtpClientHandler : IHttpHandler
    {
        private readonly IClient _client;

        public CtpClientHandler(IClient client)
        {
            _client = client;
        }

        public void Dispose()
        {
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.RequestUri = new Uri("test-php-dev-integration-1/graphql", UriKind.Relative);
            return await _client.SendAsAsync(request, cancellationToken);
        }
    }
}