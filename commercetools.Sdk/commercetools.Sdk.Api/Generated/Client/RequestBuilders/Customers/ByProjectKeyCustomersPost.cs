using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public partial class ByProjectKeyCustomersPost : ApiMethod<ByProjectKeyCustomersPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Customers.CustomerDraft CustomerDraft;
   
       public ByProjectKeyCustomersPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Customers.CustomerDraft customerDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.CustomerDraft = customerDraft;
           this.RequestUrl = $"/{ProjectKey}/customers";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomersPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
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
              var body = this.SerializerService.Serialize(CustomerDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
