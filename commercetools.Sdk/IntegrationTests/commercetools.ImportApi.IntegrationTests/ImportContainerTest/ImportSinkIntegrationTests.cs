using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Client;
using commercetools.Sdk.ImportApi.Extensions;
using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customers;
using commercetools.Sdk.ImportApi.Models.Importcontainers;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using Xunit;

namespace commercetools.ImportApi.IntegrationTests.ImportContainerTest
{
    [Collection("Integration Tests")]
    public class ImportContainerIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;
        private readonly ProjectApiRoot _apiRoot;
        public ImportContainerIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("ImportClient");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
            this._apiRoot = _client.WithImportApi(_projectKey);
        }

        [Fact]
        [System.Obsolete]
        public async Task CreateAndDelete()
        {
            var container = await _apiRoot.ImportContainers().Post(new ImportContainerDraft()
            {
                Key = "test-" + TestingUtility.RandomString(),
                ResourceType = IImportResourceType.Customer,

            })
                .ExecuteAsync().ConfigureAwait(false);

            var random = TestingUtility.RandomString();
            var res = await _apiRoot.Customers().ImportContainers().WithImportContainerKeyValue(container.Key)
                .Post(new CustomerImportRequest()
                {
                    Resources = new List<ICustomerImport>()
                    {
                        new CustomerImport()
                        {
                            Key = "test" + random,
                            FirstName = "test",
                            Email = "test-" + random,
                            Password = "abc-" + random
                        }
                    }
                }).ExecuteAsync().ConfigureAwait(false);

            Assert.NotEmpty(res.OperationStatus.First().OperationId);
        }
    }
}