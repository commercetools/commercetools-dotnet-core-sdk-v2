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
   public partial class ByProjectKeyCustomersPasswordTokenByPasswordTokenGet : ApiMethod<ByProjectKeyCustomersPasswordTokenByPasswordTokenGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string PasswordToken { get; }
       
   
       public ByProjectKeyCustomersPasswordTokenByPasswordTokenGet(IClient apiHttpClient, string projectKey, string passwordToken) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.PasswordToken = passwordToken;
           this.RequestUrl = $"/{ProjectKey}/customers/password-token={PasswordToken}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomersPasswordTokenByPasswordTokenGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Customers.ICustomer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.ICustomer>(requestMessage);
       }
   }
}
