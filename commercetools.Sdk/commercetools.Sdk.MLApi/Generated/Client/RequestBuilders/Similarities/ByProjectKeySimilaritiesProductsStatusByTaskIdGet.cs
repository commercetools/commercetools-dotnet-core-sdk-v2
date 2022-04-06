using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Similarities
{
    public partial class ByProjectKeySimilaritiesProductsStatusByTaskIdGet : ApiMethod<ByProjectKeySimilaritiesProductsStatusByTaskIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string TaskId { get; }


        public ByProjectKeySimilaritiesProductsStatusByTaskIdGet(IClient apiHttpClient, string projectKey, string taskId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.TaskId = taskId;
            this.RequestUrl = $"/{ProjectKey}/similarities/products/status/{TaskId}";
        }




        public async Task<commercetools.Sdk.MLApi.Models.SimilarProducts.ISimilarProductsTaskStatus> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.SimilarProducts.ISimilarProductsTaskStatus>(requestMessage);
        }

    }
}
