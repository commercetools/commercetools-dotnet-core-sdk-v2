using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Similarities
{
    public partial class ByProjectKeySimilaritiesProductsPost : ApiMethod<ByProjectKeySimilaritiesProductsPost>, IApiMethod<ByProjectKeySimilaritiesProductsPost, commercetools.Sdk.MLApi.Models.Common.ITaskToken>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.MLApi.Models.SimilarProducts.ISimilarProductSearchRequest SimilarProductSearchRequest;

        public ByProjectKeySimilaritiesProductsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.MLApi.Models.SimilarProducts.ISimilarProductSearchRequest similarProductSearchRequest)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.SimilarProductSearchRequest = similarProductSearchRequest;
            this.RequestUrl = $"/{ProjectKey}/similarities/products";
        }




        public async Task<commercetools.Sdk.MLApi.Models.Common.ITaskToken> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.Common.ITaskToken>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(SimilarProductSearchRequest);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
