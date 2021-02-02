using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Ml.Client.RequestBuilders.MissingData;

namespace commercetools.Ml.Client.RequestBuilders.MissingData
{
   public class ByProjectKeyMissingDataImagesStatusRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMissingDataImagesStatusRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       public ByProjectKeyMissingDataImagesStatusByTaskIdRequestBuilder WithTaskId(string taskId) {
           return new ByProjectKeyMissingDataImagesStatusByTaskIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, taskId);
       }
   }
}
