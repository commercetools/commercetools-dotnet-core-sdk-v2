using commercetools.Base.Client;
using commercetools.ImportApi.Client.RequestBuilders.Projects;

namespace commercetools.Sdk.ImportApi.Client
{
    public class ImportApiRoot
    {
        private IClient ApiHttpClient { get; }
        
        public ImportApiRoot(IClient apiHttpClient)
        {
            this.ApiHttpClient = apiHttpClient;
        }

        public ByProjectKeyRequestBuilder WithProjectKey(string projectKey)
        {
            return new ByProjectKeyRequestBuilder(ApiHttpClient, ApiHttpClient?.SerializerService, projectKey);
        }
    }
}