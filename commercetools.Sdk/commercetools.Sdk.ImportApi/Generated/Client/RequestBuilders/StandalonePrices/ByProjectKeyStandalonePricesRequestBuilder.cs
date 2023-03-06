using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.StandalonePrices
{

    public partial class ByProjectKeyStandalonePricesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyStandalonePricesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyStandalonePricesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyStandalonePricesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
