using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Prices;

namespace commercetools.ImportApi.Client.RequestBuilders.Prices
{
   
   public class ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsGet Get() {
           return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsGet(ApiHttpClient, ProjectKey, ImportSinkKey);
       }
       
       
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder WithIdValue(string id) {
           return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, id);
       }
   }
}
