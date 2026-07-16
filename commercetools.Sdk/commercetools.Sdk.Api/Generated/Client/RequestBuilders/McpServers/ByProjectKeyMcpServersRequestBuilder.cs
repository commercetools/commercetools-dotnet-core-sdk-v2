using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.McpServers
{

    public partial class ByProjectKeyMcpServersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMcpServersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMcpServersGet Get()
        {
            return new ByProjectKeyMcpServersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyMcpServersPost Post(commercetools.Sdk.Api.Models.McpServers.IMcpServerDraft mcpServerDraft)
        {
            return new ByProjectKeyMcpServersPost(ApiHttpClient, SerializerService, ProjectKey, mcpServerDraft);
        }


        public ByProjectKeyMcpServersTypesRequestBuilder Types()
        {
            return new ByProjectKeyMcpServersTypesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyMcpServersKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyMcpServersKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyMcpServersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyMcpServersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
