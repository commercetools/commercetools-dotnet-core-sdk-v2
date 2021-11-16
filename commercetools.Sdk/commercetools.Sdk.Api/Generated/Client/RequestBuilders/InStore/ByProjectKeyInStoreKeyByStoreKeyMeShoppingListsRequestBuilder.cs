using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsGet(ApiHttpClient, ProjectKey, StoreKey);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost Post(commercetools.Api.Models.Me.IMyShoppingListDraft myShoppingListDraft) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, myShoppingListDraft);
       }
       
       
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
       }
   }
}
