using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.CustomObjects
{
   public partial class ByProjectKeyCustomObjectsPost : ApiMethod<ByProjectKeyCustomObjectsPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.CustomObjects.CustomObjectDraft CustomObjectDraft;
   
       public ByProjectKeyCustomObjectsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.CustomObjects.CustomObjectDraft customObjectDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.CustomObjectDraft = customObjectDraft;
           this.RequestUrl = $"/{ProjectKey}/custom-objects";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomObjectsPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.CustomObjects.CustomObject> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.CustomObjects.CustomObject>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(CustomObjectDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
