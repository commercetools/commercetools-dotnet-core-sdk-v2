using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyPost Post(commercetools.Api.Models.Me.IMyShoppingListUpdate myShoppingListUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, myShoppingListUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
