using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Recommendations
{

    public partial class ByProjectKeyRecommendationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRecommendationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyRecommendationsProjectCategoriesRequestBuilder ProjectCategories()
        {
            return new ByProjectKeyRecommendationsProjectCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyRecommendationsGeneralCategoriesRequestBuilder GeneralCategories()
        {
            return new ByProjectKeyRecommendationsGeneralCategoriesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
