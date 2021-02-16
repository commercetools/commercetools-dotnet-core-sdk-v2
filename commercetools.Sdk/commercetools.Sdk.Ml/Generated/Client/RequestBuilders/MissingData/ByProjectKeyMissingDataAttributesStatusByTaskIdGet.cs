using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Ml.Client.RequestBuilders.MissingData
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
   
   

       public async Task<commercetools.Ml.Models.MissingData.MissingDataTaskStatus> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Ml.Models.MissingData.MissingDataTaskStatus>(requestMessage);
       }
   }
}
