using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Recommendations
{

    public partial class ByProjectKeyRecommendationsProjectCategoriesByProductIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ProductId { get; }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string productId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ProductId = productId;
        }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet Get()
        {
            return new ByProjectKeyRecommendationsProjectCategoriesByProductIdGet(ApiHttpClient, ProjectKey, ProductId);
        }

    }
}
