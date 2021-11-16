using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{

    public class ByProjectKeyMissingDataRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMissingDataRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       
       public ByProjectKeyMissingDataAttributesRequestBuilder Attributes() {
           return new ByProjectKeyMissingDataAttributesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyMissingDataImagesRequestBuilder Images() {
           return new ByProjectKeyMissingDataImagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       
       public ByProjectKeyMissingDataPricesRequestBuilder Prices() {
           return new ByProjectKeyMissingDataPricesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
   }
}
