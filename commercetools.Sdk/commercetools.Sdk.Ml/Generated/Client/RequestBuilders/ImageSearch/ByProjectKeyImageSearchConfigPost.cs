using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Ml.Client.RequestBuilders.ImageSearch
{
   public partial class ByProjectKeyImageSearchConfigPost : ApiMethod<ByProjectKeyImageSearchConfigPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Ml.Models.ImageSearchConfigs.IImageSearchConfigRequest ImageSearchConfigRequest;
   
       public ByProjectKeyImageSearchConfigPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Ml.Models.ImageSearchConfigs.IImageSearchConfigRequest imageSearchConfigRequest) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImageSearchConfigRequest = imageSearchConfigRequest;
           this.RequestUrl = $"/{ProjectKey}/image-search/config";
       }
   
   

       public async Task<commercetools.Ml.Models.ImageSearchConfigs.ImageSearchConfigResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Ml.Models.ImageSearchConfigs.ImageSearchConfigResponse>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ImageSearchConfigRequest);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
