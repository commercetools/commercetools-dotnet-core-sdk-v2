using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Models.Common;

namespace commercetools.ImportApi.Client.RequestBuilders.Inventories
{
   public partial class ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet : ApiMethod<ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
   
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet(IClient apiHttpClient, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.RequestUrl = $"/{ProjectKey}/inventories/importSinkKey={ImportSinkKey}/import-operations";
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
       
       public List<string> GetResourceKey() {
           return this.GetQueryParam("resourceKey");
       }
       
       public List<string> GetState() {
           return this.GetQueryParam("state");
       }
       
       public List<string> GetDebug() {
           return this.GetQueryParam("debug");
       }
   
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet WithLimit(double limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet WithOffset(double offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet WithResourceKey(string resourceKey){
           return this.AddQueryParam("resourceKey", resourceKey);
       }
       
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet WithState(IProcessingState state){
           return this.AddQueryParam("state", state.ToString());
       }
       
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet WithDebug(bool debug){
           return this.AddQueryParam("debug", debug.ToString());
       }

       public async Task<commercetools.ImportApi.Models.Importoperations.ImportOperationPagedResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importoperations.ImportOperationPagedResponse>(requestMessage);
       }
   }
}
