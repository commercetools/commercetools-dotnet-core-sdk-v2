using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public partial class ByProjectKeyCustomersPasswordResetPost : ApiMethod<ByProjectKeyCustomersPasswordResetPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Customers.ICustomerResetPassword CustomerResetPassword;
   
       public ByProjectKeyCustomersPasswordResetPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Customers.ICustomerResetPassword customerResetPassword) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.CustomerResetPassword = customerResetPassword;
           this.RequestUrl = $"/{ProjectKey}/customers/password/reset";
       }
   
   

       public async Task<commercetools.Api.Models.Customers.ICustomer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.ICustomer>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(CustomerResetPassword);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
