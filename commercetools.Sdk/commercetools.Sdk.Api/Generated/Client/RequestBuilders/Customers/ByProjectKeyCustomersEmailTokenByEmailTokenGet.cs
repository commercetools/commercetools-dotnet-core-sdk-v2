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
   public partial class ByProjectKeyCustomersEmailTokenByEmailTokenGet : ApiMethod<ByProjectKeyCustomersEmailTokenByEmailTokenGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string EmailToken { get; }
       
   
       public ByProjectKeyCustomersEmailTokenByEmailTokenGet(IClient apiHttpClient, string projectKey, string emailToken) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.EmailToken = emailToken;
           this.RequestUrl = $"/{ProjectKey}/customers/email-token={EmailToken}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomersEmailTokenByEmailTokenGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Customers.Customer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.Customer>(requestMessage);
       }
   }
}
