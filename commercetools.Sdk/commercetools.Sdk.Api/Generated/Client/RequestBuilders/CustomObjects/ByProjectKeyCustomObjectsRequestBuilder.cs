using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.CustomObjects;

namespace commercetools.Api.Client.RequestBuilders.CustomObjects
{
   public class ByProjectKeyCustomObjectsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomObjectsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomObjectsGet Get() {
           return new ByProjectKeyCustomObjectsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyCustomObjectsPost Post(commercetools.Api.Models.CustomObjects.CustomObjectDraft customObjectDraft) {
           return new ByProjectKeyCustomObjectsPost(ApiHttpClient, SerializerService, ProjectKey, customObjectDraft);
       }
       
       public ByProjectKeyCustomObjectsByContainerByKeyRequestBuilder WithContainerAndKey(string container ,string key) {
           return new ByProjectKeyCustomObjectsByContainerByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, container, key);
       }
       public ByProjectKeyCustomObjectsByContainerRequestBuilder WithContainer(string container) {
           return new ByProjectKeyCustomObjectsByContainerRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, container);
       }
   }
}
