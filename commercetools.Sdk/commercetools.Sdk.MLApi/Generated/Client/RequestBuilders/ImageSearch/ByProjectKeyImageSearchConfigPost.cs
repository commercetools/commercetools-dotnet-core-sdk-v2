using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.MLApi.Client.RequestBuilders.ImageSearch
{
   public partial class ByProjectKeyImageSearchConfigPost : ApiMethod<ByProjectKeyImageSearchConfigPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigRequest ImageSearchConfigRequest;
   
       public ByProjectKeyImageSearchConfigPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigRequest imageSearchConfigRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImageSearchConfigRequest = imageSearchConfigRequest;
           this.RequestUrl = $"/{ProjectKey}/image-search/config";
       }
   
   

       public async Task<commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ImageSearchConfigRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
