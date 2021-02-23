using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.InStore;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyShoppingListsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsGet(ApiHttpClient, ProjectKey, StoreKey);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsPost Post(commercetools.Api.Models.ShoppingLists.IShoppingListDraft shoppingListDraft) {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, shoppingListDraft);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
       }
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
       }
   }
}
