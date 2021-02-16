using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Subscriptions
{
   public partial class ByProjectKeySubscriptionsGet : ApiMethod<ByProjectKeySubscriptionsGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeySubscriptionsGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/subscriptions";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
       
       public List<string> GetSort() {
           return this.GetQueryParam("sort");
       }
       
       public List<string> GetLimit() {
           return this.GetQueryParam("limit");
       }
       
       public List<string> GetOffset() {
           return this.GetQueryParam("offset");
       }
       
       public List<string> GetWithTotal() {
           return this.GetQueryParam("withTotal");
       }
       
       public List<string> GetWhere() {
           return this.GetQueryParam("where");
       }
   
       public ByProjectKeySubscriptionsGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       
       public ByProjectKeySubscriptionsGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeySubscriptionsGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeySubscriptionsGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeySubscriptionsGet WithWithTotal(bool withTotal){
           return this.AddQueryParam("withTotal", withTotal.ToString());
       }
       
       public ByProjectKeySubscriptionsGet WithWhere(string where){
           return this.AddQueryParam("where", where);
       }

       public async Task<commercetools.Api.Models.Subscriptions.SubscriptionPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Subscriptions.SubscriptionPagedQueryResponse>(requestMessage);
       }
   }
}
