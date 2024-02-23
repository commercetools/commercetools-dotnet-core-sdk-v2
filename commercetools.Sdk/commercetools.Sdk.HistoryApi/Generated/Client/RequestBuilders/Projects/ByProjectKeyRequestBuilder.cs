using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.HistoryApi.Client.RequestBuilders.ResourceType;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Client.RequestBuilders.Projects
{

    public partial class ByProjectKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyGet Get()
        {
            return new ByProjectKeyGet(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyByResourceTypeRequestBuilder WithResourceTypeValue(string resourceType)
        {
            return new ByProjectKeyByResourceTypeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, resourceType);
        }
    }
}
