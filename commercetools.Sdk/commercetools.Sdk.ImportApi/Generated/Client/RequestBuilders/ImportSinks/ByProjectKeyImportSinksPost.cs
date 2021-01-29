using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportSinks
{
   public partial class ByProjectKeyImportSinksPost : ApiMethod<ByProjectKeyImportSinksPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.ImportApi.Models.Importsinks.IImportSinkDraft ImportSinkDraft;
   
       public ByProjectKeyImportSinksPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.ImportApi.Models.Importsinks.IImportSinkDraft importSinkDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkDraft = importSinkDraft;
           this.RequestUrl = $"/{ProjectKey}/import-sinks";
       }
   
   

       public async Task<commercetools.ImportApi.Models.Importsinks.ImportSink> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importsinks.ImportSink>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ImportSinkDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
