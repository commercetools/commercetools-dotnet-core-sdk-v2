using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public partial class ByProjectKeyShippingMethodsMatchingLocationGet : ApiMethod<ByProjectKeyShippingMethodsMatchingLocationGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyShippingMethodsMatchingLocationGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-location";
       }
   
       public List<string> GetCountry() {
           return this.GetQueryParam("country");
       }
       
       public List<string> GetState() {
           return this.GetQueryParam("state");
       }
       
       public List<string> GetCurrency() {
           return this.GetQueryParam("currency");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyShippingMethodsMatchingLocationGet WithCountry(string country){
           return this.AddQueryParam("country", country);
       }
       
       public ByProjectKeyShippingMethodsMatchingLocationGet WithState(string state){
           return this.AddQueryParam("state", state);
       }
       
       public ByProjectKeyShippingMethodsMatchingLocationGet WithCurrency(string currency){
           return this.AddQueryParam("currency", currency);
       }
       
       public ByProjectKeyShippingMethodsMatchingLocationGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       

       public async Task<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage);
       }
   }
}
