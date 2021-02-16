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
   public partial class ByProjectKeyMissingDataPricesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataPricesStatusByTaskIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string TaskId { get; }
       
   
       public ByProjectKeyMissingDataPricesStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.TaskId = taskId;
           this.RequestUrl = $"/{ProjectKey}/missing-data/prices/status/{TaskId}";
       }
   
   

       public async Task<commercetools.Ml.Models.MissingData.MissingPricesTaskStatus> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Ml.Models.MissingData.MissingPricesTaskStatus>(requestMessage);
       }
   }
}
