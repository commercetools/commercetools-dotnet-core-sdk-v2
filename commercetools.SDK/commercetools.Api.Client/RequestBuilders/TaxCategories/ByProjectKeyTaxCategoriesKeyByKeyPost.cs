using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
   public partial class ByProjectKeyTaxCategoriesKeyByKeyPost : ApiMethod<ByProjectKeyTaxCategoriesKeyByKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
       private commercetools.Api.Models.TaxCategorys.TaxCategoryUpdate TaxCategoryUpdate;
   
       public ByProjectKeyTaxCategoriesKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Api.Models.TaxCategorys.TaxCategoryUpdate taxCategoryUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.TaxCategoryUpdate = taxCategoryUpdate;
           this.RequestUrl = $"/{ProjectKey}/tax-categories/key={Key}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyTaxCategoriesKeyByKeyPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.TaxCategorys.TaxCategory> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.TaxCategorys.TaxCategory>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(TaxCategoryUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
