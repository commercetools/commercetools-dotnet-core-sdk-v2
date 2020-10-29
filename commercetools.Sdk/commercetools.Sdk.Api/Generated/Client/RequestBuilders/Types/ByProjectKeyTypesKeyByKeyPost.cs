using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Types
{
   public partial class ByProjectKeyTypesKeyByKeyPost : ApiMethod<ByProjectKeyTypesKeyByKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
       private commercetools.Api.Models.Types.TypeUpdate TypeUpdate;
   
       public ByProjectKeyTypesKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Api.Models.Types.TypeUpdate typeUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.TypeUpdate = typeUpdate;
           this.RequestUrl = $"/{ProjectKey}/types/key={Key}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyTypesKeyByKeyPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Types.Type> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Types.Type>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(TypeUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
