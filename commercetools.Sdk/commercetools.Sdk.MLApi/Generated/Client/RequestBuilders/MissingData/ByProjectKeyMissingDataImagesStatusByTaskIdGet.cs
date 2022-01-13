using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.MLApi.Client.RequestBuilders.MissingData
{
    public partial class ByProjectKeyMissingDataImagesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataImagesStatusByTaskIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string TaskId { get; }


        public ByProjectKeyMissingDataImagesStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.TaskId = taskId;
            this.RequestUrl = $"/{ProjectKey}/missing-data/images/status/{TaskId}";
        }




        public async Task<commercetools.MLApi.Models.MissingData.IMissingImagesTaskStatus> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.MissingData.IMissingImagesTaskStatus>(requestMessage);
        }

    }
}
