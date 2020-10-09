using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordPost Post(commercetools.Api.Models.Customers.CustomerChangePassword customerChangePassword) {
           return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerChangePassword);
       }
       
   }
}
