using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
   public partial class ByProjectKeyTaxCategoriesGet : ApiMethod<ByProjectKeyTaxCategoriesGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyTaxCategoriesGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/tax-categories";
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
   
       public ByProjectKeyTaxCategoriesGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       
       public ByProjectKeyTaxCategoriesGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeyTaxCategoriesGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyTaxCategoriesGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyTaxCategoriesGet WithWithTotal(bool withTotal){
           return this.AddQueryParam("withTotal", withTotal.ToString());
       }
       
       public ByProjectKeyTaxCategoriesGet WithWhere(string where){
           return this.AddQueryParam("where", where);
       }

       public async Task<commercetools.Api.Models.TaxCategories.TaxCategoryPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.TaxCategories.TaxCategoryPagedQueryResponse>(requestMessage);
       }
   }
}
