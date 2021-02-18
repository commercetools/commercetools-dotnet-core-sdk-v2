using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.MissingData;

namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
   public class ByProjectKeyMissingDataImagesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMissingDataImagesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMissingDataImagesPost Post(commercetools.MLApi.Models.MissingData.IMissingImagesSearchRequest missingImagesSearchRequest) {
           return new ByProjectKeyMissingDataImagesPost(ApiHttpClient, SerializerService, ProjectKey, missingImagesSearchRequest);
       }
       
       public ByProjectKeyMissingDataImagesStatusRequestBuilder Status() {
           return new ByProjectKeyMissingDataImagesStatusRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
   }
}
