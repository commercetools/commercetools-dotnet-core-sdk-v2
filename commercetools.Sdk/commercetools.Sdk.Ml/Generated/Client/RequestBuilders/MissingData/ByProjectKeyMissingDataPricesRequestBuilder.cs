using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Ml.Client.RequestBuilders.MissingData;

namespace commercetools.Ml.Client.RequestBuilders.MissingData
{
   public class ByProjectKeyMissingDataPricesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMissingDataPricesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMissingDataPricesPost Post(commercetools.Ml.Models.MissingData.IMissingPricesSearchRequest missingPricesSearchRequest) {
           return new ByProjectKeyMissingDataPricesPost(ApiHttpClient, SerializerService, ProjectKey, missingPricesSearchRequest);
       }
       
       public ByProjectKeyMissingDataPricesStatusRequestBuilder Status() {
           return new ByProjectKeyMissingDataPricesStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
   }
}
