using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyCartsGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCartsGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet(IClient apiHttpClient, string projectKey, string storeKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/carts";
       }
   
       public List<string> GetCustomerId() {
           return this.GetQueryParam("customerId");
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
   
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithCustomerId(string customerId){
           return this.AddQueryParam("customerId", customerId);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithWithTotal(bool withTotal){
           return this.AddQueryParam("withTotal", withTotal.ToString());
       }
       
       public ByProjectKeyInStoreKeyByStoreKeyCartsGet WithWhere(string where){
           return this.AddQueryParam("where", where);
       }

       public async Task<Object> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<Object>(requestMessage);
       }
   }
}
