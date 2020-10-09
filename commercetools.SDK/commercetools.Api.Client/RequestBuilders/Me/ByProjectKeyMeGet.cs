using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMeGet : ApiMethod<ByProjectKeyMeGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyMeGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/me";
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
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
       
       public List<string> GetWhere() {
           return this.GetQueryParam("where");
       }
   
       public ByProjectKeyMeGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeyMeGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyMeGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyMeGet WithWithTotal(bool withTotal){
           return this.AddQueryParam("withTotal", withTotal.ToString());
       }
       
       public ByProjectKeyMeGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       
       public ByProjectKeyMeGet WithWhere(string where){
           return this.AddQueryParam("where", where);
       }

       public async Task<commercetools.Api.Models.Me.MyCustomer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Me.MyCustomer>(requestMessage);
       }
   }
}
