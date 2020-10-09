using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.InStore
{
   public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string StoreKey { get; }
       
       private string EmailToken { get; }
       
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenGet(IClient apiHttpClient, string projectKey, string storeKey, string emailToken) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.StoreKey = storeKey;
           this.EmailToken = emailToken;
           this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/customers/email-token={EmailToken}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenByEmailTokenGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.Customers.Customer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Customers.Customer>(requestMessage);
       }
   }
}
