using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ByProjectKeyMissingDataImagesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataImagesStatusByTaskIdGet>, IApiMethod<ByProjectKeyMissingDataImagesStatusByTaskIdGet, commercetools.Sdk.MLApi.Models.MissingData.IMissingImagesTaskStatus>
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




        public async Task<commercetools.Sdk.MLApi.Models.MissingData.IMissingImagesTaskStatus> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.MissingData.IMissingImagesTaskStatus>(requestMessage, cancellationToken);
        }

    }
}
