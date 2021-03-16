using commercetools.Base.Client;
using commercetools.Api.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.Api.Client
{
    public class ApiRoot
    {
        private IClient ApiHttpClient { get; }
        
        public ApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }

        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}
