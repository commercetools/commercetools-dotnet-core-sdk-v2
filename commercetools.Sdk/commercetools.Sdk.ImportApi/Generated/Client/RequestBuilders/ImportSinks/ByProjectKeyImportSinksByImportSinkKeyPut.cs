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
   public partial class ByProjectKeyImportSinksByImportSinkKeyPut : ApiMethod<ByProjectKeyImportSinksByImportSinkKeyPut> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Put;
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private commercetools.ImportApi.Models.Importsinks.IImportSinkDraft ImportSinkDraft;
   
       public ByProjectKeyImportSinksByImportSinkKeyPut(IClient apiHttpClient, string projectKey, string importSinkKey, commercetools.ImportApi.Models.Importsinks.IImportSinkDraft importSinkDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.ImportSinkDraft = importSinkDraft;
           this.RequestUrl = $"/{ProjectKey}/import-sinks/{ImportSinkKey}";
       }
   
   

       public async Task<commercetools.ImportApi.Models.Importsinks.ImportSink> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importsinks.ImportSink>(requestMessage);
       }
   }
}
