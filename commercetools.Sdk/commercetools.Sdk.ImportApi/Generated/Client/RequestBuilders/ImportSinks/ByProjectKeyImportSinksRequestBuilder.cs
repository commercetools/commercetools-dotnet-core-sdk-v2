using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ImportSinks;

namespace commercetools.ImportApi.Client.RequestBuilders.ImportSinks
{
   
   public class ByProjectKeyImportSinksRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyImportSinksRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyImportSinksPost Post(commercetools.ImportApi.Models.Importsinks.IImportSinkDraft importSinkDraft) {
           return new ByProjectKeyImportSinksPost(ApiHttpClient, SerializerService, ProjectKey, importSinkDraft);
       }
       
       public ByProjectKeyImportSinksGet Get() {
           return new ByProjectKeyImportSinksGet(ApiHttpClient, ProjectKey);
       }
       
       
       public ByProjectKeyImportSinksByImportSinkKeyRequestBuilder WithImportSinkKeyValue(string importSinkKey) {
           return new ByProjectKeyImportSinksByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
       }
   }
}
