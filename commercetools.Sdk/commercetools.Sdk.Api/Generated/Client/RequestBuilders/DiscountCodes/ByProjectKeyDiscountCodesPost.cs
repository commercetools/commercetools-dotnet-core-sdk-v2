using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.DiscountCodes
{
   public partial class ByProjectKeyDiscountCodesPost : ApiMethod<ByProjectKeyDiscountCodesPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.DiscountCodes.IDiscountCodeDraft DiscountCodeDraft;
   
       public ByProjectKeyDiscountCodesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.DiscountCodes.IDiscountCodeDraft discountCodeDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.DiscountCodeDraft = discountCodeDraft;
           this.RequestUrl = $"/{ProjectKey}/discount-codes";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyDiscountCodesPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.DiscountCodes.DiscountCode> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.DiscountCodes.DiscountCode>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(DiscountCodeDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
