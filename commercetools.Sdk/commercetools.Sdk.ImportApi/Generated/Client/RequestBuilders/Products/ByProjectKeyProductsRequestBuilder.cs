using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.Products;

namespace commercetools.ImportApi.Client.RequestBuilders.Products
{
   public class ByProjectKeyProductsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyProductsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       public ByProjectKeyProductsImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey) {
           return new ByProjectKeyProductsImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
       }
   }
}
