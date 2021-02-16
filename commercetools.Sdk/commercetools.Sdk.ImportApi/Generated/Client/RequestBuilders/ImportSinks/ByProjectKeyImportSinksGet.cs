using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportSinks
{
   public partial class ByProjectKeyImportSinksGet : ApiMethod<ByProjectKeyImportSinksGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyImportSinksGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.RequestUrl = $"/{ProjectKey}/import-sinks";
       }
   
       public List<string> GetLimit() {
           return this.GetQueryParam("limit");
       }
       
       public List<string> GetOffset() {
           return this.GetQueryParam("offset");
       }
   
       public ByProjectKeyImportSinksGet WithLimit(double limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyImportSinksGet WithOffset(double offset){
           return this.AddQueryParam("offset", offset.ToString());
       }

       public async Task<commercetools.ImportApi.Models.Importsinks.ImportSinkPagedResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importsinks.ImportSinkPagedResponse>(requestMessage);
       }
   }
}
