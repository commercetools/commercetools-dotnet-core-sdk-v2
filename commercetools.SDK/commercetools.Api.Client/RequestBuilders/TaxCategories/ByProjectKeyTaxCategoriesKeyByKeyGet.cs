using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
   public partial class ByProjectKeyTaxCategoriesKeyByKeyGet : ApiMethod<ByProjectKeyTaxCategoriesKeyByKeyGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
   
       public ByProjectKeyTaxCategoriesKeyByKeyGet(IClient apiHttpClient, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.RequestUrl = $"/{ProjectKey}/tax-categories/key={Key}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyTaxCategoriesKeyByKeyGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.TaxCategorys.TaxCategory> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.TaxCategorys.TaxCategory>(requestMessage);
       }
   }
}
