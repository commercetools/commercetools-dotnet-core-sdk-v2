using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDGet(IClient apiHttpClient, string projectKey, string storeKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/shopping-lists/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyShoppingListsByIDGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.ShoppingLists.ShoppingList> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShoppingLists.ShoppingList>(requestMessage);
       }
   }
}
