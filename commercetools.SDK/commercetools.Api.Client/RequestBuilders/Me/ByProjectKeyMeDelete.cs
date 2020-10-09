using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Me
{
   public partial class ByProjectKeyMeDelete : ApiMethod<ByProjectKeyMeDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyMeDelete(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/me";
       }
   
       public List<string> GetVersion() {
           return this.GetQueryParam("version");
       }
   
       public ByProjectKeyMeDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }

       public async Task<commercetools.Api.Models.Me.MyCustomer> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Me.MyCustomer>(requestMessage);
       }
   }
}
