using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Client.RequestBuilders.ProductDrafts;

namespace commercetools.ImportApi.Client.RequestBuilders.ProductDrafts
{
   
   public class ByProjectKeyProductDraftsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyProductDraftsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyRequestBuilder ImportSinkKeyWithImportSinkKeyValue(string importSinkKey) {
           return new ByProjectKeyProductDraftsImportSinkKeyByImportSinkKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importSinkKey);
       }
   }
}
