using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
    public partial class ByProjectKeyMissingDataAttributesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataAttributesStatusByTaskIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string TaskId { get; }
       
   
       public ByProjectKeyMissingDataAttributesStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.TaskId = taskId;
           this.RequestUrl = $"/{ProjectKey}/missing-data/attributes/status/{TaskId}";
       }
   
   
       

       public async Task<commercetools.MLApi.Models.MissingData.IMissingDataTaskStatus> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.MissingData.IMissingDataTaskStatus>(requestMessage);
       }

   }
}
