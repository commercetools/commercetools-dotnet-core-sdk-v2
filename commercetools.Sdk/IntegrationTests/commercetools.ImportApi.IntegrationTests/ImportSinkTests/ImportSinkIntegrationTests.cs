using commercetools.Base.Client;
using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importsinks;
using commercetools.Sdk.ImportApi.Extensions;
using Xunit;

namespace commercetools.ImportApi.IntegrationTests.ImportSinkTests
{
    [Collection("Integration Tests")]
    public class ImportSinkIntegrationTests
    {
        private readonly IClient _client;
        private readonly string _projectKey;
        public ImportSinkIntegrationTests(ServiceProviderFixture serviceProviderFixture)
        {
            var clientConfiguration = serviceProviderFixture.GetClientConfiguration("ImportClient");
            this._client = serviceProviderFixture.GetService<IClient>();
            this._projectKey = clientConfiguration.ProjectKey;
        }

        [Fact]
        [System.Obsolete]
        public async void CreateAndDelete()
        {
            var importSinkDraft = new ImportSinkDraft
            {
                Key = $"sink-{TestingUtility.RandomInt()}",
                ResourceType = IImportResourceType.Customer
            };
            var importSink = await _client.WithImportApi().WithProjectKeyValue(_projectKey)
                .ImportSinks()
                .Post(importSinkDraft)
                .ExecuteAsync();

            Assert.NotNull(importSink);

            var deletedImportSink = await _client.WithImportApi().WithProjectKeyValue(_projectKey)
                .ImportSinks()
                .WithImportSinkKeyValue(importSink.Key)
                .Delete()
                .ExecuteAsync();
            Assert.NotNull(deletedImportSink);
            Assert.Equal(importSink.Key, deletedImportSink.Key);
        }
    }
}