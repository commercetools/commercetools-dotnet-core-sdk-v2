using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMeShoppingListsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyMeShoppingListsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyMeShoppingListsByIDGet Get() {
           return new ByProjectKeyMeShoppingListsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyMeShoppingListsByIDPost Post(commercetools.Api.Models.Me.MyShoppingListUpdate myShoppingListUpdate) {
           return new ByProjectKeyMeShoppingListsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myShoppingListUpdate);
       }
       
       public ByProjectKeyMeShoppingListsByIDDelete Delete() {
           return new ByProjectKeyMeShoppingListsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
