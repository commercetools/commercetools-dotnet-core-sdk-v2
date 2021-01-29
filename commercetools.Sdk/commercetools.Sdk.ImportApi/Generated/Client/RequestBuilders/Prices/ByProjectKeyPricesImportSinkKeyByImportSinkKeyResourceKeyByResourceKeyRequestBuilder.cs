using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.Prices
{
   public class ByProjectKeyPricesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string ResourceKey { get; }
   
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, string resourceKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.ResourceKey = resourceKey;
       }
   
       public ByProjectKeyPricesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete Delete() {
           return new ByProjectKeyPricesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete(ApiHttpClient, ProjectKey, ImportSinkKey, ResourceKey);
       }
       
   }
}
