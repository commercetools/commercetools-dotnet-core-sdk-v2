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


namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public partial class ByProjectKeyShippingMethodsMatchingOrdereditGet : ApiMethod<ByProjectKeyShippingMethodsMatchingOrdereditGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyShippingMethodsMatchingOrdereditGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-orderedit";
       }
   
       public List<string> GetOrderEditId() {
           return this.GetQueryParam("orderEditId");
       }
       
       public List<string> GetCountry() {
           return this.GetQueryParam("country");
       }
       
       public List<string> GetState() {
           return this.GetQueryParam("state");
       }
   
       public ByProjectKeyShippingMethodsMatchingOrdereditGet WithOrderEditId(string orderEditId){
           return this.AddQueryParam("orderEditId", orderEditId);
       }
       
       public ByProjectKeyShippingMethodsMatchingOrdereditGet WithCountry(string country){
           return this.AddQueryParam("country", country);
       }
       
       public ByProjectKeyShippingMethodsMatchingOrdereditGet WithState(string state){
           return this.AddQueryParam("state", state);
       }
       

       public async Task<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage);
       }

   }
}
