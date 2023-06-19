using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductProjectionsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyProductProjectionsGet Get()
        {
            return new ByProjectKeyProductProjectionsGet(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyProductProjectionsSearchRequestBuilder Search()
        {
            return new ByProjectKeyProductProjectionsSearchRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductProjectionsSuggestRequestBuilder Suggest()
        {
            return new ByProjectKeyProductProjectionsSuggestRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyProductProjectionsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyProductProjectionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyProductProjectionsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyProductProjectionsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
