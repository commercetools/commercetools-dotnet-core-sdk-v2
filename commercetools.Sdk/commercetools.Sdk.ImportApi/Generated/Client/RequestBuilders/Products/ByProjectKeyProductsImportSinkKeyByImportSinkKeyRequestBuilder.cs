using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Products;

namespace commercetools.ImportApi.Client.RequestBuilders.Products
{
   public class ByProjectKeyProductsImportSinkKeyByImportSinkKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ImportSinkKey { get; }
   
       public ByProjectKeyProductsImportSinkKeyByImportSinkKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importSinkKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ImportSinkKey = importSinkKey;
       }
   
       public ByProjectKeyProductsImportSinkKeyByImportSinkKeyPost Post(commercetools.ImportApi.Models.Importrequests.IProductImportRequest productImportRequest) {
           return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, productImportRequest);
       }
       
       public ByProjectKeyProductsImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder ResourceKeyWithResourceKeyValue(string resourceKey) {
           return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyResourceKeyByResourceKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey, resourceKey);
       }
       public ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder ImportOperations() {
           return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyImportOperationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ImportSinkKey);
       }
   }
}
