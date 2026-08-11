using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.McpServers
{

    public partial class ByProjectKeyMcpServersTypesByMcpServerTypeRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string McpServerType { get; }

        public ByProjectKeyMcpServersTypesByMcpServerTypeRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string mcpServerType)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.McpServerType = mcpServerType;
        }

        public ByProjectKeyMcpServersTypesByMcpServerTypeGet Get()
        {
            return new ByProjectKeyMcpServersTypesByMcpServerTypeGet(ApiHttpClient, ProjectKey, McpServerType);
        }

    }
}
