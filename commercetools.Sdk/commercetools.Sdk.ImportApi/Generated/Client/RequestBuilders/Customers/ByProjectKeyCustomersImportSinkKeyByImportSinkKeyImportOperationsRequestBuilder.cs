using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Customers;

namespace commercetools.ImportApi.Client.RequestBuilders.Customers
{
   
   public class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsGet Get() {
           return new ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
       }
       
       
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id) {
           return new ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
       }
   }
}
