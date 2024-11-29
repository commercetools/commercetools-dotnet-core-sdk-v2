using System.Linq;
using commercetools.Api.IntegrationTests;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Extensions;
using commercetools.Sdk.ImportApi.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using ProjectApiRoot = commercetools.Sdk.Api.Client.ProjectApiRoot;
using ImportProjectApiRoot = commercetools.Sdk.ImportApi.Client.ProjectApiRoot;

namespace commercetools.Sdk.ImportApi.Tests
{
    public class MultipleClientsTest
    {
        [Fact]
        public async void api_and_import()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();

            var s = new ServiceCollection();
            s.UseCommercetoolsImportApi(configuration, "Import");
            s.UseCommercetoolsApi(configuration, "Client");
            var p = s.BuildServiceProvider();

            var apiConfig = configuration.GetSection("Client").Get<ClientConfiguration>();
            var importApiRoot = p.GetService<ImportProjectApiRoot>();
            var apiRoot = p.GetService<ProjectApiRoot>();

            Assert.Equal("Import", importApiRoot.ClientName);
            Assert.Equal("Client", apiRoot.ClientName);
            var project = await apiRoot.Get().ExecuteAsync().ConfigureAwait(false);

            Assert.Equal(apiConfig.ProjectKey, project.Key);

            var importContainers = await importApiRoot.ImportContainers().Get().ExecuteAsync().ConfigureAwait(false);
            Assert.NotNull(importContainers);


        }

        [Fact]
        public async void api_and_import_create_root()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();

            var s = new ServiceCollection();
            s.UseCommercetoolsImportApi(configuration, "Import");
            s.UseCommercetoolsApi(configuration, "Client");
            var p = s.BuildServiceProvider();

            var clients = p.GetServices<IClient>();

            var importConfig = configuration.GetSection("Import").Get<ClientConfiguration>();
            var apiConfig = configuration.GetSection("Client").Get<ClientConfiguration>();

            var importApiRoot = clients.First(client => client.Name == "Import")
                .WithImportApi(importConfig.ProjectKey);
            var apiRoot = clients.First(client => client.Name == "Client")
                .WithProject(apiConfig.ProjectKey);

            Assert.Equal("Import", importApiRoot.ClientName);
            Assert.Equal("Client", apiRoot.ClientName);

            var project = await apiRoot.Get().ExecuteAsync().ConfigureAwait(false);

            Assert.Equal(apiConfig.ProjectKey, project.Key);

            var importContainers = await importApiRoot.ImportContainers().Get().ExecuteAsync().ConfigureAwait(false);
            Assert.NotNull(importContainers);


        }
    }
}