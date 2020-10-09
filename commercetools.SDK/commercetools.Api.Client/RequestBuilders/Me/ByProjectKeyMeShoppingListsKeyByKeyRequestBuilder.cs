using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyMeShoppingListsKeyByKeyGet Get() {
           return new ByProjectKeyMeShoppingListsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyMeShoppingListsKeyByKeyPost Post(commercetools.Api.Models.Me.MyShoppingListUpdate myShoppingListUpdate) {
           return new ByProjectKeyMeShoppingListsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myShoppingListUpdate);
       }
       
       public ByProjectKeyMeShoppingListsKeyByKeyDelete Delete() {
           return new ByProjectKeyMeShoppingListsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
