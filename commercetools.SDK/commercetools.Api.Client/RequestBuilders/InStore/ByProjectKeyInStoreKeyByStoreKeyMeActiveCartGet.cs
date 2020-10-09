using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyMeActiveCartGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyMeActiveCartGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyMeActiveCartGet(IClient apiHttpClient, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/me/active-cart";
       }
   
   

       public async Task<commercetools.Api.Models.Carts.Cart> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Carts.Cart>(requestMessage);
       }
   }
}
