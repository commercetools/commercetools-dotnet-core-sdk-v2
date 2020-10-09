using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.Me;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMeCartsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMeCartsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMeCartsGet Get() {
           return new ByProjectKeyMeCartsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyMeCartsPost Post(commercetools.Api.Models.Me.MyCartDraft myCartDraft) {
           return new ByProjectKeyMeCartsPost(ApiHttpClient, SerializerService, ProjectKey, myCartDraft);
       }
       
       public ByProjectKeyMeCartsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyMeCartsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
