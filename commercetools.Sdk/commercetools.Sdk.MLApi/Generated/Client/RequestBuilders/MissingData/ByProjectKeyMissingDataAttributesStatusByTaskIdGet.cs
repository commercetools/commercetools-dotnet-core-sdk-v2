using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    public partial class ByProjectKeyMissingDataAttributesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataAttributesStatusByTaskIdGet>, IApiMethod<ByProjectKeyMissingDataAttributesStatusByTaskIdGet, commercetools.Sdk.MLApi.Models.MissingData.IMissingDataTaskStatus>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string TaskId { get; }


        public ByProjectKeyMissingDataAttributesStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.TaskId = taskId;
            this.RequestUrl = $"/{ProjectKey}/missing-data/attributes/status/{TaskId}";
        }




        public async Task<commercetools.Sdk.MLApi.Models.MissingData.IMissingDataTaskStatus> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.MissingData.IMissingDataTaskStatus>(requestMessage);
        }

    }
}
