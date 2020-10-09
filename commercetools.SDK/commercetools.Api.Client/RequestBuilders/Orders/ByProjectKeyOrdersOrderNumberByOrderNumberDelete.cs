using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Orders
{
   public partial class ByProjectKeyOrdersOrderNumberByOrderNumberDelete : ApiMethod<ByProjectKeyOrdersOrderNumberByOrderNumberDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string OrderNumber { get; }
       
   
       public ByProjectKeyOrdersOrderNumberByOrderNumberDelete(IClient apiHttpClient, string projectKey, string orderNumber) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.OrderNumber = orderNumber;
           this.RequestUrl = $"/{ProjectKey}/orders/order-number={OrderNumber}";
       }
   
       public List<string> GetDataErasure() {
           return this.GetQueryParam("dataErasure");
       }
       
       public List<string> GetVersion() {
           return this.GetQueryParam("version");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyOrdersOrderNumberByOrderNumberDelete WithDataErasure(bool dataErasure){
           return this.AddQueryParam("dataErasure", dataErasure.ToString());
       }
       
       public ByProjectKeyOrdersOrderNumberByOrderNumberDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }
       
       public ByProjectKeyOrdersOrderNumberByOrderNumberDelete WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Orders.Order> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.Order>(requestMessage);
       }
   }
}
