using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.ImageSearch
{

    public partial class ByProjectKeyImageSearchConfigPost : ApiMethod<ByProjectKeyImageSearchConfigPost>, IApiMethod<ByProjectKeyImageSearchConfigPost, commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigRequest ImageSearchConfigRequest;

        public ByProjectKeyImageSearchConfigPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigRequest imageSearchConfigRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImageSearchConfigRequest = imageSearchConfigRequest;
            this.RequestUrl = $"/{ProjectKey}/image-search/config";
        }




        public async Task<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.ImageSearchConfigs.IImageSearchConfigResponse>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(ImageSearchConfigRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
