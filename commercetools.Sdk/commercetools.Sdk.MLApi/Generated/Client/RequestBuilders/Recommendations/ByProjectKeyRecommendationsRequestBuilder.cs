using System;
using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.Recommendations;

namespace commercetools.MLApi.Client.RequestBuilders.Recommendations
{

    public class ByProjectKeyRecommendationsRequestBuilder
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
