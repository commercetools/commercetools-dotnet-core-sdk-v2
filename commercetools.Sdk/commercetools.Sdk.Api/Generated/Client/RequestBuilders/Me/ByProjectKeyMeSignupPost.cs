using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMeSignupPost : ApiMethod<ByProjectKeyMeSignupPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Me.IMyCustomerDraft MyCustomerDraft;
   
       public ByProjectKeyMeSignupPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Me.IMyCustomerDraft myCustomerDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.MyCustomerDraft = myCustomerDraft;
           this.RequestUrl = $"/{ProjectKey}/me/signup";
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
              var body = this.SerializerService.Serialize(MyCustomerDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
