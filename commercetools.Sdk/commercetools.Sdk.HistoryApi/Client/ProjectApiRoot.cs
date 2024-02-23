using commercetools.Base.Client;
using commercetools.Sdk.HistoryApi.Client.RequestBuilders.Projects;
using commercetools.Sdk.HistoryApi.Client.RequestBuilders.ResourceType;

namespace commercetools.Sdk.HistoryApi.Client
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
            return new HistoryApiRoot(ApiHttpClient).WithProjectKeyValue(ProjectKey);
        }

        public ByProjectKeyGet Get()
        {
            return With().Get();
        }

        public ByProjectKeyByResourceTypeRequestBuilder WithResourceType(string resourceType)
        {
            return With().WithResourceTypeValue(resourceType);
        }
    }
}