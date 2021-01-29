using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Ml.Client.RequestBuilders.Similarities
{
   public class ByProjectKeySimilaritiesProductsStatusByTaskIdRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string TaskId { get; }
   
       public ByProjectKeySimilaritiesProductsStatusByTaskIdRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string taskId) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.TaskId = taskId;
       }
   
       public ByProjectKeySimilaritiesProductsStatusByTaskIdGet Get() {
           return new ByProjectKeySimilaritiesProductsStatusByTaskIdGet(ApiHttpClient, ProjectKey, TaskId);
       }
       
   }
}
