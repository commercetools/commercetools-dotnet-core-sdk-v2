using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyLoginPost : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyLoginPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private commercetools.Api.Models.Customers.CustomerSignin CustomerSignin;
   
       public ByProjectKeyInStoreKeyByStoreKeyLoginPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, commercetools.Api.Models.Customers.CustomerSignin customerSignin) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.CustomerSignin = customerSignin;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/login";
       }
   
   

       public async Task<commercetools.Api.Models.Customers.CustomerSignInResult> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.CustomerSignInResult>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(CustomerSignin);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
