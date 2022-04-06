using commercetools.Base.Client;
using commercetools.Sdk.HistoryApi.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.HistoryApi.Client
{
    public class HistoryApiRoot
    {
        private IClient ApiHttpClient { get; }

        public HistoryApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }
        public ByProjectKeyRequestBuilder WithProjectKeyValue(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}