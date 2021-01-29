using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductTypes
{
   public class ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string ResourceKey { get; }
   
       public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, string resourceKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.ResourceKey = resourceKey;
       }
   
       public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete Delete() {
           return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete(ApiHttpClient, ProjectKey, ImportSinkKey, ResourceKey);
       }
       
   }
}
