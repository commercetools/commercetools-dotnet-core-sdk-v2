using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
   
   public class ByProjectKeyMissingDataAttributesStatusByTaskIdRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string TaskId { get; }
   
       public ByProjectKeyMissingDataAttributesStatusByTaskIdRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string taskId) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.TaskId = taskId;
       }
   
       public ByProjectKeyMissingDataAttributesStatusByTaskIdGet Get() {
           return new ByProjectKeyMissingDataAttributesStatusByTaskIdGet(ApiHttpClient, ProjectKey, TaskId);
       }
       
   }
}
