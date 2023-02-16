using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.ImageSearch
{

    public partial class ByProjectKeyImageSearchConfigGet : ApiMethod<ByProjectKeyImageSearchConfigGet>, IApiMethod<ByProjectKeyImageSearchConfigGet, commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyImageSearchConfigGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/image-search/config";
        }




        public async Task<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
