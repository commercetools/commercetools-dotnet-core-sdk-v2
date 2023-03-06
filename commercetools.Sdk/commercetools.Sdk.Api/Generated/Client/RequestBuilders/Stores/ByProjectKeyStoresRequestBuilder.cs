using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Stores
{

    public partial class ByProjectKeyStoresRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyStoresRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyStoresGet Get()
        {
            return new ByProjectKeyStoresGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyStoresPost Post(commercetools.Sdk.Api.Models.Stores.IStoreDraft storeDraft)
        {
            return new ByProjectKeyStoresPost(ApiHttpClient, SerializerService, ProjectKey, storeDraft);
        }


        public ByProjectKeyStoresKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyStoresKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyStoresByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyStoresByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
