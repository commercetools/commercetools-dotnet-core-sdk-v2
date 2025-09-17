using commercetools.Base.Client;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.CheckoutApi.Client
{
    public class CheckoutApiRoot
    {
        private IClient ApiHttpClient { get; }

        public CheckoutApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }
        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}