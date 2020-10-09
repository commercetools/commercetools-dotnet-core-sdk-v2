using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyLoginRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyLoginRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyLoginPost Post(commercetools.Api.Models.Customers.CustomerSignin customerSignin) {
           return new ByProjectKeyInStoreKeyByStoreKeyLoginPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerSignin);
       }
       
   }
}
