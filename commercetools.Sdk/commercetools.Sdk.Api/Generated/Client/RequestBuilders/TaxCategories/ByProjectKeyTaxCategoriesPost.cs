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
   public partial class ByProjectKeyTaxCategoriesPost : ApiMethod<ByProjectKeyTaxCategoriesPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.TaxCategories.ITaxCategoryDraft TaxCategoryDraft;
   
       public ByProjectKeyTaxCategoriesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.TaxCategories.ITaxCategoryDraft taxCategoryDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.TaxCategoryDraft = taxCategoryDraft;
           this.RequestUrl = $"/{ProjectKey}/tax-categories";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyTaxCategoriesPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.TaxCategories.ITaxCategory> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.TaxCategories.ITaxCategory>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(TaxCategoryDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
