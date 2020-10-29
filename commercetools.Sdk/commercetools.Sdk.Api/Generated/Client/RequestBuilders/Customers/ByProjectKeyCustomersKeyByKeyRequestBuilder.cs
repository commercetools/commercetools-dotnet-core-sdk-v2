using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public class ByProjectKeyCustomersKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyCustomersKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyCustomersKeyByKeyGet Get() {
           return new ByProjectKeyCustomersKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyCustomersKeyByKeyPost Post(commercetools.Api.Models.Customers.CustomerUpdate customerUpdate) {
           return new ByProjectKeyCustomersKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, customerUpdate);
       }
       
       public ByProjectKeyCustomersKeyByKeyDelete Delete() {
           return new ByProjectKeyCustomersKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
