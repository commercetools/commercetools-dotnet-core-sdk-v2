using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.ImportSinks
{
   public class ByProjectKeyImportSinksByImportSinkKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyImportSinksByImportSinkKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyImportSinksByImportSinkKeyPut Put(commercetools.ImportApi.Models.Importsinks.IImportSinkDraft importSinkDraft) {
           return new ByProjectKeyImportSinksByImportSinkKeyPut(ApiHttpClient, ProjectKey, ImportSinkKey, importSinkDraft);
       }
       
       public ByProjectKeyImportSinksByImportSinkKeyGet Get() {
           return new ByProjectKeyImportSinksByImportSinkKeyGet(ApiHttpClient, ProjectKey, ImportSinkKey);
       }
       
       public ByProjectKeyImportSinksByImportSinkKeyDelete Delete() {
           return new ByProjectKeyImportSinksByImportSinkKeyDelete(ApiHttpClient, ProjectKey, ImportSinkKey);
       }
       
   }
}
