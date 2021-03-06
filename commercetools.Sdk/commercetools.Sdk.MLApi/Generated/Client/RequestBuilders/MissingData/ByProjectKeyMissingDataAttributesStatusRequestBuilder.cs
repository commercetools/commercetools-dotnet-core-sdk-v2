using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.MissingData;

namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
   public class ByProjectKeyMissingDataAttributesStatusRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMissingDataAttributesStatusRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       public ByProjectKeyMissingDataAttributesStatusByTaskIdRequestBuilder WithTaskId(string taskId) {
           return new ByProjectKeyMissingDataAttributesStatusByTaskIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, taskId);
       }
   }
}
