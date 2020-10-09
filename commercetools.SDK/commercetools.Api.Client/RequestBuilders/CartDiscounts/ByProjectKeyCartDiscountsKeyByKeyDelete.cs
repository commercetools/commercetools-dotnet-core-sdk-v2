using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.CartDiscounts
{
   public partial class ByProjectKeyCartDiscountsKeyByKeyDelete : ApiMethod<ByProjectKeyCartDiscountsKeyByKeyDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
   
       public ByProjectKeyCartDiscountsKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.RequestUrl = $"/{ProjectKey}/cart-discounts/key={Key}";
       }
   
       public List<string> GetVersion() {
           return this.GetQueryParam("version");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCartDiscountsKeyByKeyDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }
       
       public ByProjectKeyCartDiscountsKeyByKeyDelete WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.CartDiscounts.CartDiscount> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.CartDiscounts.CartDiscount>(requestMessage);
       }
   }
}
