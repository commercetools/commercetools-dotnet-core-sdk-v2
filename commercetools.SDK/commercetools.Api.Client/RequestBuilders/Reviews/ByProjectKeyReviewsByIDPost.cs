using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Reviews
{
   public partial class ByProjectKeyReviewsByIDPost : ApiMethod<ByProjectKeyReviewsByIDPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
       private commercetools.Api.Models.Reviews.ReviewUpdate ReviewUpdate;
   
       public ByProjectKeyReviewsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Api.Models.Reviews.ReviewUpdate reviewUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.ReviewUpdate = reviewUpdate;
           this.RequestUrl = $"/{ProjectKey}/reviews/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyReviewsByIDPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Reviews.Review> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Reviews.Review>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ReviewUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
