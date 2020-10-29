using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public class ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmPost Post(commercetools.Api.Models.Customers.CustomerEmailVerify customerEmailVerify) {
           return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailConfirmPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerEmailVerify);
       }
       
   }
}
