using commercetools.Base.Client;
using commercetools.MLApi.Client.RequestBuilders.ImageSearch;
using commercetools.MLApi.Client.RequestBuilders.MissingData;
using commercetools.MLApi.Client.RequestBuilders.Projects;
using commercetools.MLApi.Client.RequestBuilders.Recommendations;
using commercetools.MLApi.Client.RequestBuilders.Similarities;

namespace commercetools.Sdk.MLApi.Client
{
    public class ProjectApiRoot
    {
        public string ClientName { get; }

        private string ProjectKey { get; }

        private IClient ApiHttpClient { get; }

        public ProjectApiRoot(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ClientName = apiHttpClient.Name;
        }

        private ByProjectKeyRequestBuilder With()
        {
            return new MLApiRoot(ApiHttpClient).WithProjectKey(ProjectKey);
        }

        public ByProjectKeyRecommendationsRequestBuilder Recommendations()
        {
            return With().Recommendations();
        }

        public ByProjectKeySimilaritiesRequestBuilder Similarities()
        {
            return With().Similarities();
        }

        public ByProjectKeyImageSearchRequestBuilder ImageSearch()
        {
            return With().ImageSearch();
        }

        public ByProjectKeyMissingDataRequestBuilder MissingData()
        {
            return With().MissingData();
        }
    }
}