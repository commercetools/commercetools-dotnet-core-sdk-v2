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
   public partial class ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet(IClient apiHttpClient, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/shipping-methods/matching-cart";
       }
   
       public List<string> GetCartId() {
           return this.GetQueryParam("cartId");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet WithCartId(string cartId){
           return this.AddQueryParam("cartId", cartId);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       

       public async Task<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage);
       }

   }
}
