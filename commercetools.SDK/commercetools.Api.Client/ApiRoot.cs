using commercetools.Api.Client.RequestBuilders;

namespace commercetools.Api.Client
{
    public class ApiRoot
    {
        private IClient ApiHttpClient { get; set; }

        public ApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }

        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, projectKey);
        }
    }
}
