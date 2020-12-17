using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Types
{
   public class ByProjectKeyTypesByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyTypesByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyTypesByIDGet Get() {
           return new ByProjectKeyTypesByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyTypesByIDPost Post(commercetools.Api.Models.Types.ITypeUpdate typeUpdate) {
           return new ByProjectKeyTypesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, typeUpdate);
       }
       
       public ByProjectKeyTypesByIDDelete Delete() {
           return new ByProjectKeyTypesByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
