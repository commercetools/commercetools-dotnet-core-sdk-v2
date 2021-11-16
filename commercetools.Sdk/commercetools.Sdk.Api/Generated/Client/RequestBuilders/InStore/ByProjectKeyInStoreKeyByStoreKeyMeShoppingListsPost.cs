using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private commercetools.Api.Models.Me.IMyShoppingListDraft MyShoppingListDraft;
   
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Api.Models.Me.IMyShoppingListDraft myShoppingListDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.MyShoppingListDraft = myShoppingListDraft;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/shopping-lists";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyMeShoppingListsPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       

       public async Task<commercetools.Api.Models.ShoppingLists.IShoppingList> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShoppingLists.IShoppingList>(requestMessage);
       }
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(MyShoppingListDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }

   }
}
