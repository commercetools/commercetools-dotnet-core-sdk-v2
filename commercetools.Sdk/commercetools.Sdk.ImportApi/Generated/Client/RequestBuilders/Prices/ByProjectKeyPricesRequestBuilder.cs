using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Prices
{

    public class ByProjectKeyPricesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyPricesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyPricesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyPricesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
