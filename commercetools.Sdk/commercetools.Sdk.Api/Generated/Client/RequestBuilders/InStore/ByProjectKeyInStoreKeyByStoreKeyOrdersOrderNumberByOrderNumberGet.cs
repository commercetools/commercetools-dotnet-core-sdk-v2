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
   public partial class ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string OrderNumber { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet(IClient apiHttpClient, string projectKey, string storeKey, string orderNumber) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.OrderNumber = orderNumber;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/orders/order-number={OrderNumber}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersOrderNumberByOrderNumberGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Orders.Order> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.Order>(requestMessage);
       }
   }
}
