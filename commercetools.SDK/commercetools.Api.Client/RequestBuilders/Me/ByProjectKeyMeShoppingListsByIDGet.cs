using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMeShoppingListsByIDGet : ApiMethod<ByProjectKeyMeShoppingListsByIDGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
   
       public ByProjectKeyMeShoppingListsByIDGet(IClient apiHttpClient, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.RequestUrl = $"/{ProjectKey}/me/shopping-lists/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyMeShoppingListsByIDGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.ShoppingLists.MyShoppingList> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShoppingLists.MyShoppingList>(requestMessage);
       }
   }
}
