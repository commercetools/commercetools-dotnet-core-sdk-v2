using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Orders
{
   public partial class ByProjectKeyOrdersEditsByIDApplyPost : ApiMethod<ByProjectKeyOrdersEditsByIDApplyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
       private commercetools.Api.Models.OrderEdits.IOrderEditApply OrderEditApply;
   
       public ByProjectKeyOrdersEditsByIDApplyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Api.Models.OrderEdits.IOrderEditApply orderEditApply) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.OrderEditApply = orderEditApply;
           this.RequestUrl = $"/{ProjectKey}/orders/edits/{ID}/apply";
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
              var body = this.SerializerService.Serialize(OrderEditApply);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
