using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.CustomObjects
{
   public partial class ByProjectKeyCustomObjectsByContainerGet : ApiMethod<ByProjectKeyCustomObjectsByContainerGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string Container { get; }
       
   
       public ByProjectKeyCustomObjectsByContainerGet(IClient apiHttpClient, string projectKey, string container) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Container = container;
           this.RequestUrl = $"/{ProjectKey}/custom-objects/{Container}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomObjectsByContainerGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }

       public async Task<commercetools.Api.Models.CustomObjects.CustomObject> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.CustomObjects.CustomObject>(requestMessage);
       }
   }
}
