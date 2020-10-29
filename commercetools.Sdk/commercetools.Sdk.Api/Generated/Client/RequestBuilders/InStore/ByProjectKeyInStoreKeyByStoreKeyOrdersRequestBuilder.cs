using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.InStore;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyOrdersRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersGet(ApiHttpClient, ProjectKey, StoreKey);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyOrdersPost Post(commercetools.Api.Models.Orders.OrderFromCartDraft orderFromCartDraft) {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, orderFromCartDraft);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberRequestBuilder WithOrderNumber(string orderNumber) {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, orderNumber);
       }
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyInStoreKeyByStoreKeyOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
       }
   }
}
