using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   
   public class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDPost Post(commercetools.Api.Models.Me.IMyShoppingListUpdate myShoppingListUpdate) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, myShoppingListUpdate);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDDelete Delete() {
           return new ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
       }
       
   }
}
