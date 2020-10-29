using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Login
{
   public partial class ByProjectKeyLoginPost : ApiMethod<ByProjectKeyLoginPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Customers.CustomerSignin CustomerSignin;
   
       public ByProjectKeyLoginPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Customers.CustomerSignin customerSignin) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.CustomerSignin = customerSignin;
           this.RequestUrl = $"/{ProjectKey}/login";
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
