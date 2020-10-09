using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.CustomObjects
{
   public class ByProjectKeyCustomObjectsByContainerRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Container { get; }
   
       public ByProjectKeyCustomObjectsByContainerRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string container) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Container = container;
       }
   
       public ByProjectKeyCustomObjectsByContainerGet Get() {
           return new ByProjectKeyCustomObjectsByContainerGet(ApiHttpClient, ProjectKey, Container);
       }
       
   }
}
