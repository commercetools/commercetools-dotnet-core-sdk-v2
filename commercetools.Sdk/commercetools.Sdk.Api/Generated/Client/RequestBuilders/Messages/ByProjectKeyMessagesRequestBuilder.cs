using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Messages;

namespace commercetools.Api.Client.RequestBuilders.Messages
{
   
   public class ByProjectKeyMessagesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMessagesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMessagesGet Get() {
           return new ByProjectKeyMessagesGet(ApiHttpClient, ProjectKey);
       }
       
       
       public ByProjectKeyMessagesByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyMessagesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
