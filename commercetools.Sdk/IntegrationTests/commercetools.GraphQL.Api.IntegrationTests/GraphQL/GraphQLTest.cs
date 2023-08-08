using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.GraphQL.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.GraphQL.Api.IntegrationTests.GraphQL;

public class GraphQLTest
{

    [Fact]
    // ReSharper disable once InconsistentNaming
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


        var client = provider.GetService<ProjectApiRoot>().GraphQLClient();
        
        var response = await client.Query( o => o.Products(selector: r => new { results = r.Results(product => new { product.Id }) }));

        Assert.NotNull(response.Data?.results);
        Assert.Null(response.Errors);
    }
}