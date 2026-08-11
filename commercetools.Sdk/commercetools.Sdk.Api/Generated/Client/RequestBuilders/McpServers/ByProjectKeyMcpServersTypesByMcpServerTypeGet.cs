using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.McpServers
{

    public partial class ByProjectKeyMcpServersTypesByMcpServerTypeGet : ApiMethod<ByProjectKeyMcpServersTypesByMcpServerTypeGet>, IApiMethod<ByProjectKeyMcpServersTypesByMcpServerTypeGet, commercetools.Sdk.Api.Models.McpServers.IMcpServerType>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMcpServersTypesByMcpServerTypeGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMcpServersTypesByMcpServerTypeGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string McpServerType { get; }


        public ByProjectKeyMcpServersTypesByMcpServerTypeGet(IClient apiHttpClient, string projectKey, string mcpServerType)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.McpServerType = mcpServerType;
            this.RequestUrl = $"/{ProjectKey}/mcp-servers/types/{McpServerType}";
        }

        public List<string> GetMajorVersion()
        {
            return this.GetQueryParam("majorVersion");
        }

        public ByProjectKeyMcpServersTypesByMcpServerTypeGet WithMajorVersion(string majorVersion)
        {
            return this.AddQueryParam("majorVersion", majorVersion);
        }


        public async Task<commercetools.Sdk.Api.Models.McpServers.IMcpServerType> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.McpServers.IMcpServerType>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.McpServers.IMcpServerType>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.McpServers.IMcpServerType>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
