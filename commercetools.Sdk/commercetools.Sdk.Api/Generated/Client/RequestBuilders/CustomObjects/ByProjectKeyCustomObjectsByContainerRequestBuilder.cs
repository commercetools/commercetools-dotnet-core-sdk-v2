using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{

    public partial class ByProjectKeyCustomObjectsByContainerRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Container { get; }

        public ByProjectKeyCustomObjectsByContainerRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string container)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Container = container;
        }

        public ByProjectKeyCustomObjectsByContainerGet Get()
        {
            return new ByProjectKeyCustomObjectsByContainerGet(ApiHttpClient, ProjectKey, Container);
        }

    }
}
