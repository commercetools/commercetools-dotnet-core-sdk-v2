using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.InStore;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyCartsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyCartsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsGet(ApiHttpClient, ProjectKey, StoreKey);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsPost Post(commercetools.Api.Models.Carts.CartDraft cartDraft) {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, cartDraft);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdRequestBuilder WithCustomerId(string customerId) {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerId);
       }
       public ByProjectKeyInStoreKeyByStoreKeyCartsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyInStoreKeyByStoreKeyCartsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
       }
   }
}
