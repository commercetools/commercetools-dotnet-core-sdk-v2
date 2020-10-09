using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.States
{
   public class ByProjectKeyStatesKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyStatesKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyStatesKeyByKeyGet Get() {
           return new ByProjectKeyStatesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyStatesKeyByKeyPost Post(commercetools.Api.Models.States.StateUpdate stateUpdate) {
           return new ByProjectKeyStatesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, stateUpdate);
       }
       
       public ByProjectKeyStatesKeyByKeyDelete Delete() {
           return new ByProjectKeyStatesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
