using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeOrdersByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMeOrdersByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMeOrdersByIDGet Get()
        {
            return new ByProjectKeyMeOrdersByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMeOrdersByIDHead Head()
        {
            return new ByProjectKeyMeOrdersByIDHead(ApiHttpClient, ProjectKey, ID);
        }

    }
}
