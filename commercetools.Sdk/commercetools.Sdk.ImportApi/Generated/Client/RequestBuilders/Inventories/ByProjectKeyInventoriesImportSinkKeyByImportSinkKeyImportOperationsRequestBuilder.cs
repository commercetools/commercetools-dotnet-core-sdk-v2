using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Inventories;

namespace commercetools.ImportApi.Client.RequestBuilders.Inventories
{
   public class ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet Get() {
           return new ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
       }
       
       public ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id) {
           return new ByProjectKeyInventoriesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
       }
   }
}
