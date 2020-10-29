using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMeShoppingListsByIDPost : ApiMethod<ByProjectKeyMeShoppingListsByIDPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
       private commercetools.Api.Models.Me.MyShoppingListUpdate MyShoppingListUpdate;
   
       public ByProjectKeyMeShoppingListsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Api.Models.Me.MyShoppingListUpdate myShoppingListUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.MyShoppingListUpdate = myShoppingListUpdate;
           this.RequestUrl = $"/{ProjectKey}/me/shopping-lists/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyMeShoppingListsByIDPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.ShoppingLists.MyShoppingList> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShoppingLists.MyShoppingList>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(MyShoppingListUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
