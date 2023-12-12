using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyProductProjectionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyProductProjectionsByIDGet Get()
        {
            return new ByProjectKeyProductProjectionsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyProductProjectionsByIDHead Head()
        {
            return new ByProjectKeyProductProjectionsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

    }
}
