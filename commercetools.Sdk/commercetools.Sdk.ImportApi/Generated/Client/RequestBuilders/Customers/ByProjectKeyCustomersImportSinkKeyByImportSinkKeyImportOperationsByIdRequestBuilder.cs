using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.Customers
{
   public class ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string Id { get; }
   
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.Id = id;
       }
   
       public ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet Get() {
           return new ByProjectKeyCustomersImportSinkKeyByImportSinkKeyImportOperationsByIdGet(ApiHttpClient, ProjectKey, ImportSinkKey, Id);
       }
       
   }
}
