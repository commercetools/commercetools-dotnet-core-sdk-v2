using commercetools.Base.Client;
using commercetools.HistoryApi.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.HistoryApi.Client
{
    public class HistoryApiRoot
    {
        private IClient ApiHttpClient { get; }
        
        public HistoryApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }
        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}