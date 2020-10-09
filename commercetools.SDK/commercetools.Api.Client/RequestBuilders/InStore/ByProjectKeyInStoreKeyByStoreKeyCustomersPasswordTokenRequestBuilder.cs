using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost Post(commercetools.Api.Models.Customers.CustomerCreatePasswordResetToken customerCreatePasswordResetToken) {
           return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerCreatePasswordResetToken);
       }
       
   }
}
