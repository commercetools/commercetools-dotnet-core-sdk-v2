using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Orders;

namespace commercetools.ImportApi.Client.RequestBuilders.Orders
{
   public class ByProjectKeyOrdersImportSinkKeyByImportSinkKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyPost Post(commercetools.ImportApi.Models.Importrequests.IOrderImportRequest orderImportRequest) {
           return new ByProjectKeyOrdersImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, orderImportRequest);
       }
       
       public ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations() {
           return new ByProjectKeyOrdersImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
       }
   }
}
