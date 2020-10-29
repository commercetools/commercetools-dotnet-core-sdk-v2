using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ShoppingLists
{
   public class ByProjectKeyShoppingListsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyShoppingListsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyShoppingListsByIDGet Get() {
           return new ByProjectKeyShoppingListsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyShoppingListsByIDPost Post(commercetools.Api.Models.ShoppingLists.ShoppingListUpdate shoppingListUpdate) {
           return new ByProjectKeyShoppingListsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, shoppingListUpdate);
       }
       
       public ByProjectKeyShoppingListsByIDDelete Delete() {
           return new ByProjectKeyShoppingListsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
