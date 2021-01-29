using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Prices;

namespace commercetools.ImportApi.Client.RequestBuilders.Prices
{
   public class ByProjectKeyPricesImportSinkKeyByImportSinkKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyPost Post(commercetools.ImportApi.Models.Importrequests.IPriceImportRequest priceImportRequest) {
           return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, priceImportRequest);
       }
       
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder ResourceKeyWithResourceKeyValue(string resourceKey) {
           return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, resourceKey);
       }
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations() {
           return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
       }
   }
}
