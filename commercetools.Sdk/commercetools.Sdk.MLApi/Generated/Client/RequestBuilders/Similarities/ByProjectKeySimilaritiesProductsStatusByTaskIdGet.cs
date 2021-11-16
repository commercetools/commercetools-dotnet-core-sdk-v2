using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.MLApi.Client.RequestBuilders.Similarities
{
   public partial class ByProjectKeySimilaritiesProductsStatusByTaskIdGet : ApiMethod<ByProjectKeySimilaritiesProductsStatusByTaskIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string TaskId { get; }
       
   
       public ByProjectKeySimilaritiesProductsStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.TaskId = taskId;
           this.RequestUrl = $"/{ProjectKey}/similarities/products/status/{TaskId}";
       }
   
   
       

       public async Task<commercetools.MLApi.Models.SimilarProducts.ISimilarProductsTaskStatus> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.SimilarProducts.ISimilarProductsTaskStatus>(requestMessage);
       }

   }
}
