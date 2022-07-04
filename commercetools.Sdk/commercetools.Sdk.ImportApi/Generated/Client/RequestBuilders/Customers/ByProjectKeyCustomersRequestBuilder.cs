using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers
{

    public class ByProjectKeyCustomersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyCustomersImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyCustomersImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
