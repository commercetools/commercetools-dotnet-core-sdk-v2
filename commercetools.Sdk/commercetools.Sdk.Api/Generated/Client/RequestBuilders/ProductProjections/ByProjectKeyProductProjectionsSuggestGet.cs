using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Api.Client.RequestBuilders.ProductProjections
{
    public partial class ByProjectKeyProductProjectionsSuggestGet : ApiMethod<ByProjectKeyProductProjectionsSuggestGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyProductProjectionsSuggestGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/product-projections/suggest";
       }
   
       public List<string> GetFuzzy() {
           return this.GetQueryParam("fuzzy");
       }
       
       public List<string> GetStaged() {
           return this.GetQueryParam("staged");
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
   
       public ByProjectKeyProductProjectionsSuggestGet WithFuzzy(bool fuzzy){
           return this.AddQueryParam("fuzzy", fuzzy.ToString());
       }
       
       public ByProjectKeyProductProjectionsSuggestGet WithStaged(bool staged){
           return this.AddQueryParam("staged", staged.ToString());
       }
       
       public ByProjectKeyProductProjectionsSuggestGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeyProductProjectionsSuggestGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyProductProjectionsSuggestGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyProductProjectionsSuggestGet WithWithTotal(bool withTotal){
           return this.AddQueryParam("withTotal", withTotal.ToString());
       }
       
       public ByProjectKeyProductProjectionsSuggestGet WithSearchKeywords(string locale, string searchKeywords){
           return this.AddQueryParam($"searchKeywords.{locale}", searchKeywords);
       }

       public async Task<Object> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<Object>(requestMessage);
       }

   }
}
