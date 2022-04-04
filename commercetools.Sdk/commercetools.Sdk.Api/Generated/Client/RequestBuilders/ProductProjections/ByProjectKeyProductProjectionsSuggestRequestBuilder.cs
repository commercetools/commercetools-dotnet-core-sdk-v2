using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public class ByProjectKeyProductProjectionsSuggestRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductProjectionsSuggestRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductProjectionsSuggestGet Get()
        {
            return new ByProjectKeyProductProjectionsSuggestGet(ApiHttpClient, ProjectKey);
        }

    }
}
