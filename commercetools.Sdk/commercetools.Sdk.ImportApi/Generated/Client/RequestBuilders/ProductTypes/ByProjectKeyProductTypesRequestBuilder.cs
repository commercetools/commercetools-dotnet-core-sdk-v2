using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductTypes;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductTypes
{
   
   public class ByProjectKeyProductTypesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyProductTypesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey) {
           return new ByProjectKeyProductTypesImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
       }
   }
}
