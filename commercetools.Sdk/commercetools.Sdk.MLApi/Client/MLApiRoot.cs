using commercetools.Base.Client;
using commercetools.MLApi.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.MLApi.Client
{
    public class MLApiRoot
    {
        private IClient ApiHttpClient { get; }

        public MLApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }
        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}