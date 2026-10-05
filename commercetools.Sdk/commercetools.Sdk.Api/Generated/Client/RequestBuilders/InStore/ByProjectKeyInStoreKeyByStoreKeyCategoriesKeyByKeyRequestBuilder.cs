using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyPost Post(commercetools.Sdk.Api.Models.Categories.ICategoryUpdate categoryUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, categoryUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
