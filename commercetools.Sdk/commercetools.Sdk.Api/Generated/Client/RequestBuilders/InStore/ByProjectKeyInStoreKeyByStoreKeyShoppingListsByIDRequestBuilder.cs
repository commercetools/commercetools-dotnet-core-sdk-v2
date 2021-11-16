using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDPost Post(commercetools.Api.Models.ShoppingLists.IShoppingListUpdate shoppingListUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, shoppingListUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
