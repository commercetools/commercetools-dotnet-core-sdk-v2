using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ByProjectKeyMissingDataPricesStatusByTaskIdGet : ApiMethod<ByProjectKeyMissingDataPricesStatusByTaskIdGet>, IApiMethod<ByProjectKeyMissingDataPricesStatusByTaskIdGet, commercetools.Sdk.MLApi.Models.MissingData.IMissingPricesTaskStatus>
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




        public async Task<commercetools.Sdk.MLApi.Models.MissingData.IMissingPricesTaskStatus> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.MissingData.IMissingPricesTaskStatus>(requestMessage, cancellationToken);
        }

    }
}
