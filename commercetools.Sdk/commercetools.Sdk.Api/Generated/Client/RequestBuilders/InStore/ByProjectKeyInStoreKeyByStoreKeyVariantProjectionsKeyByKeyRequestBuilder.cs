using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
