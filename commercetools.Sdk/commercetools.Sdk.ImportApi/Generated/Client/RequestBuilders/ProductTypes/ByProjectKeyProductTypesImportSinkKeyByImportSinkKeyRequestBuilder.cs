using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductTypes;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductTypes
{
   public class ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyPost Post(commercetools.ImportApi.Models.Importrequests.IProductTypeImportRequest productTypeImportRequest) {
           return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, productTypeImportRequest);
       }
       
       public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations() {
           return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
       }
   }
}
