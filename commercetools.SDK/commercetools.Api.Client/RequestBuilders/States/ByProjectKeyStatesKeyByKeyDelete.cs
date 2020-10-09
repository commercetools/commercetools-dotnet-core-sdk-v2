using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.States
{
   public partial class ByProjectKeyStatesKeyByKeyDelete : ApiMethod<ByProjectKeyStatesKeyByKeyDelete> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Delete;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
   
       public ByProjectKeyStatesKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.RequestUrl = $"/{ProjectKey}/states/key={Key}";
       }
   
       public List<string> GetVersion() {
           return this.GetQueryParam("version");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyStatesKeyByKeyDelete WithVersion(long version){
           return this.AddQueryParam("version", version.ToString());
       }
       
       public ByProjectKeyStatesKeyByKeyDelete WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.States.State> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.States.State>(requestMessage);
       }
   }
}
