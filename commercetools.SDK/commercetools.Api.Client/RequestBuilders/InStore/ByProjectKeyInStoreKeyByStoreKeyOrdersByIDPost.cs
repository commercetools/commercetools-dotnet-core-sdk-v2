using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyOrdersByIDPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyOrdersByIDPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string ID { get; }
       
       private commercetools.Api.Models.Orders.OrderUpdate OrderUpdate;
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id, commercetools.Api.Models.Orders.OrderUpdate orderUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.ID = id;
           this.OrderUpdate = orderUpdate;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/orders/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyOrdersByIDPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Orders.Order> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Orders.Order>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(OrderUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
