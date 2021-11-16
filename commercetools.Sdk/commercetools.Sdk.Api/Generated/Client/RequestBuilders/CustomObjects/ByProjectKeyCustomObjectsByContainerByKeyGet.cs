using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Api.Client.RequestBuilders.CustomObjects
{
    public partial class ByProjectKeyCustomObjectsByContainerByKeyGet : ApiMethod<ByProjectKeyCustomObjectsByContainerByKeyGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string Container { get; }
       
       private string Key { get; }
       
   
       public ByProjectKeyCustomObjectsByContainerByKeyGet(IClient apiHttpClient, string projectKey, string container, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Container = container;
           this.Key = key;
           this.RequestUrl = $"/{ProjectKey}/custom-objects/{Container}/{Key}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyCustomObjectsByContainerByKeyGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       

       public async Task<commercetools.Api.Models.CustomObjects.ICustomObject> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.CustomObjects.ICustomObject>(requestMessage);
       }

   }
}
