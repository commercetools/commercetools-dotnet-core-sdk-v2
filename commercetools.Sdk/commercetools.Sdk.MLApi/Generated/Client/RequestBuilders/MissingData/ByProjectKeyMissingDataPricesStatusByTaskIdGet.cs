using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
    public partial class ByProjectKeyMissingDataPricesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataPricesStatusByTaskIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string TaskId { get; }


        public ByProjectKeyMissingDataPricesStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.TaskId = taskId;
            this.RequestUrl = $"/{ProjectKey}/missing-data/prices/status/{TaskId}";
        }




        public async Task<commercetools.MLApi.Models.MissingData.IMissingPricesTaskStatus> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.MissingData.IMissingPricesTaskStatus>(requestMessage);
        }

    }
}
