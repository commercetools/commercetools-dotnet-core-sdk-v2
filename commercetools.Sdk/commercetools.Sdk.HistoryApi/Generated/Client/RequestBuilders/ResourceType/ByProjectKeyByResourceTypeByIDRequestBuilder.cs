using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.HistoryApi.Client.RequestBuilders.ResourceType
{

    public partial class ByProjectKeyByResourceTypeByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ResourceType { get; }

        private string ID { get; }

        public ByProjectKeyByResourceTypeByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string resourceType, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ResourceType = resourceType;
            this.ID = id;
        }

        public ByProjectKeyByResourceTypeByIDGet Get()
        {
            return new ByProjectKeyByResourceTypeByIDGet(ApiHttpClient, ProjectKey, ResourceType, ID);
        }

    }
}
