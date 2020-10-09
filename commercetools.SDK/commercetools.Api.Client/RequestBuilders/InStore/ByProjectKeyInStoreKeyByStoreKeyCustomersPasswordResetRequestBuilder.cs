using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordResetRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordResetRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordResetPost Post(commercetools.Api.Models.Customers.CustomerResetPassword customerResetPassword) {
           return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordResetPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerResetPassword);
       }
       
   }
}
