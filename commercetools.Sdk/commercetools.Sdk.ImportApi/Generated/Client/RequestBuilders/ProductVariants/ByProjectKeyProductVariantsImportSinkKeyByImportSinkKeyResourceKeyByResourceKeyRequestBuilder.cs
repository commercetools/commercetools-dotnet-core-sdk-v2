using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductVariants
{
   public class ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
       
       private string ResourceKey { get; }
   
       public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey, string resourceKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
           this.ResourceKey = resourceKey;
       }
   
       public ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete Delete() {
           return new ByProjectKeyProductVariantsImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyDelete(ApiHttpClient, ProjectKey, ImportSinkKey, ResourceKey);
       }
       
   }
}
