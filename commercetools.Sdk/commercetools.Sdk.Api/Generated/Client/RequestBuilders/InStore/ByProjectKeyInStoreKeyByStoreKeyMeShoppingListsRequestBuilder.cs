using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost Post(commercetools.Sdk.Api.Models.Me.IMyShoppingListDraft myShoppingListDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, myShoppingListDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
