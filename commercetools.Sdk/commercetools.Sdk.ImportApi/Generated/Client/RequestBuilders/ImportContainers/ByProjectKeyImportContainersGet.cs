using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportContainers
{
   public partial class ByProjectKeyImportContainersGet : ApiMethod<ByProjectKeyImportContainersGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyImportContainersGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/import-containers";
       }
   
       public List<string> GetLimit() {
           return this.GetQueryParam("limit");
       }
       
       public List<string> GetOffset() {
           return this.GetQueryParam("offset");
       }
       
       public List<string> GetSort() {
           return this.GetQueryParam("sort");
       }
   
       public ByProjectKeyImportContainersGet WithLimit(double limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyImportContainersGet WithOffset(double offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyImportContainersGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       

       public async Task<commercetools.ImportApi.Models.Importcontainers.IImportContainerPagedResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importcontainers.IImportContainerPagedResponse>(requestMessage);
       }

   }
}
