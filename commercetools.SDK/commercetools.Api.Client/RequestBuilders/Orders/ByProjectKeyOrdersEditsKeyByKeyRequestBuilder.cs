using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Orders
{
   public class ByProjectKeyOrdersEditsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyOrdersEditsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyOrdersEditsKeyByKeyGet Get() {
           return new ByProjectKeyOrdersEditsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyOrdersEditsKeyByKeyPost Post(commercetools.Api.Models.OrderEdits.OrderEditUpdate orderEditUpdate) {
           return new ByProjectKeyOrdersEditsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, orderEditUpdate);
       }
       
       public ByProjectKeyOrdersEditsKeyByKeyDelete Delete() {
           return new ByProjectKeyOrdersEditsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
