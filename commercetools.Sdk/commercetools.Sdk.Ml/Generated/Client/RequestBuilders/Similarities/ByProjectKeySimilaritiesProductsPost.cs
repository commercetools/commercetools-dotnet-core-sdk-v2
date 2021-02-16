using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Ml.Client.RequestBuilders.Similarities
{
   public partial class ByProjectKeySimilaritiesProductsPost : ApiMethod<ByProjectKeySimilaritiesProductsPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Ml.Models.SimilarProducts.ISimilarProductSearchRequest SimilarProductSearchRequest;
   
       public ByProjectKeySimilaritiesProductsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Ml.Models.SimilarProducts.ISimilarProductSearchRequest similarProductSearchRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.SimilarProductSearchRequest = similarProductSearchRequest;
           this.RequestUrl = $"/{ProjectKey}/similarities/products";
       }
   
   

       public async Task<commercetools.Ml.Models.Common.TaskToken> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Ml.Models.Common.TaskToken>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(SimilarProductSearchRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
