using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.InStore;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyMeOrdersRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeOrdersRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeOrdersGet Get() {
           return new ByProjectKeyInStoreKeyByStoreKeyMeOrdersGet(ApiHttpClient, ProjectKey, StoreKey);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeOrdersPost Post(commercetools.Api.Models.Me.MyOrderFromCartDraft myOrderFromCartDraft) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeOrdersPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, myOrderFromCartDraft);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyMeOrdersByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyInStoreKeyByStoreKeyMeOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
       }
   }
}
