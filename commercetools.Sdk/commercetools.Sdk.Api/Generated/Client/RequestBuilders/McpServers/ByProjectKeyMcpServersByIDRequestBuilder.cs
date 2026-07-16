using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.McpServers
{

    public partial class ByProjectKeyMcpServersByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyMcpServersByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyMcpServersByIDGet Get()
        {
            return new ByProjectKeyMcpServersByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyMcpServersByIDPost Post(commercetools.Sdk.Api.Models.McpServers.IMcpServerUpdate mcpServerUpdate)
        {
            return new ByProjectKeyMcpServersByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, mcpServerUpdate);
        }

        public ByProjectKeyMcpServersByIDDelete Delete()
        {
            return new ByProjectKeyMcpServersByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
