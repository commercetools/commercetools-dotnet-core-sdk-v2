using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.StandalonePrices
{

    public partial class ByProjectKeyStandalonePricesImportContainersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyStandalonePricesImportContainersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyStandalonePricesImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey)
        {
            return new ByProjectKeyStandalonePricesImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
        }
    }
}
