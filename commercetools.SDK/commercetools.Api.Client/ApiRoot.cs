using commercetools.Api.Client.RequestBuilders;
using commercetools.Api.Client.RequestBuilders.Projects;
using commercetools.Api.Serialization;

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
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}
