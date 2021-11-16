using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.CustomObjects
{

    public class ByProjectKeyCustomObjectsByContainerByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Container { get; }
       
       private string Key { get; }
   
       public ByProjectKeyCustomObjectsByContainerByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string container, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Container = container;
           this.Key = key;
       }
   
       public ByProjectKeyCustomObjectsByContainerByKeyGet Get() {
           return new ByProjectKeyCustomObjectsByContainerByKeyGet(ApiHttpClient, ProjectKey, Container, Key);
       }
       
       public ByProjectKeyCustomObjectsByContainerByKeyDelete Delete() {
           return new ByProjectKeyCustomObjectsByContainerByKeyDelete(ApiHttpClient, ProjectKey, Container, Key);
       }
       
   }
}
