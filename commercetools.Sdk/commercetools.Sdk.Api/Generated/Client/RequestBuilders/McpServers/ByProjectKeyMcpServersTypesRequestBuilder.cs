using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.McpServers
{

    public partial class ByProjectKeyMcpServersTypesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMcpServersTypesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMcpServersTypesGet Get()
        {
            return new ByProjectKeyMcpServersTypesGet(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyMcpServersTypesByMcpServerTypeRequestBuilder WithMcpServerType(string mcpServerType)
        {
            return new ByProjectKeyMcpServersTypesByMcpServerTypeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, mcpServerType);
        }
    }
}
