using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string Key { get; }
       
       private commercetools.Api.Models.Common.Update Update;
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key, commercetools.Api.Models.Common.Update update) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.Key = key;
           this.Update = update;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/customers/key={Key}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersKeyByKeyPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Customers.Customer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.Customer>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(Update);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
