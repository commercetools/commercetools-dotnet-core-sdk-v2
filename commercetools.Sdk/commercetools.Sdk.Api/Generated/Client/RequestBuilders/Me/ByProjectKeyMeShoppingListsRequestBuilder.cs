using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Me;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMeShoppingListsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMeShoppingListsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMeShoppingListsGet Get() {
           return new ByProjectKeyMeShoppingListsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyMeShoppingListsPost Post(commercetools.Api.Models.Me.MyShoppingListDraft myShoppingListDraft) {
           return new ByProjectKeyMeShoppingListsPost(ApiHttpClient, SerializerService, ProjectKey, myShoppingListDraft);
       }
       
       public ByProjectKeyMeShoppingListsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyMeShoppingListsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
       public ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyMeShoppingListsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
   }
}
