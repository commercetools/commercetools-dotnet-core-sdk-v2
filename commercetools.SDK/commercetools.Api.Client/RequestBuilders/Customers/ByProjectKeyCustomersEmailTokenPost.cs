using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public partial class ByProjectKeyCustomersEmailTokenPost : ApiMethod<ByProjectKeyCustomersEmailTokenPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Customers.CustomerCreateEmailToken CustomerCreateEmailToken;
   
       public ByProjectKeyCustomersEmailTokenPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Customers.CustomerCreateEmailToken customerCreateEmailToken) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.CustomerCreateEmailToken = customerCreateEmailToken;
           this.RequestUrl = $"/{ProjectKey}/customers/email-token";
       }
   
   

       public async Task<commercetools.Api.Models.Customers.CustomerToken> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.CustomerToken>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(CustomerCreateEmailToken);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
