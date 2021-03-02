using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDPost Post(commercetools.Api.Models.Carts.ICartUpdate cartUpdate) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, cartUpdate);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete Delete() {
           return new ByProjectKeyInStoreKeyByStoreKeyMeCartsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
       }
       
   }
}
