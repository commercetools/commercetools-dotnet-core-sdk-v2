using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMeCartsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyMeCartsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyMeCartsByIDGet Get() {
           return new ByProjectKeyMeCartsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyMeCartsByIDPost Post(commercetools.Api.Models.Common.IUpdate update) {
           return new ByProjectKeyMeCartsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, update);
       }
       
       public ByProjectKeyMeCartsByIDDelete Delete() {
           return new ByProjectKeyMeCartsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
