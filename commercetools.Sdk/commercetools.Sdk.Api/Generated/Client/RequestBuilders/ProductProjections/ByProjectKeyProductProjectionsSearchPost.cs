using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.ProductProjections
{
   public partial class ByProjectKeyProductProjectionsSearchPost : ApiMethod<ByProjectKeyProductProjectionsSearchPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private JsonElement? jsonNode;
   
       public ByProjectKeyProductProjectionsSearchPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, JsonElement? jsonNode) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.jsonNode = jsonNode;
           this.RequestUrl = $"/{ProjectKey}/product-projections/search";
       }
   
   
       

       public async Task<JsonElement> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(jsonNode);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
