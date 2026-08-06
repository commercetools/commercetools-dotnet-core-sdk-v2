

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetAuthenticationModeAction : IMcpServerSetAuthenticationModeAction
    {
        public string Action { get; set; }

        public IMcpServerAuthenticationMode AuthenticationMode { get; set; }
        public McpServerSetAuthenticationModeAction()
        {
            this.Action = "setAuthenticationMode";
        }
    }
}
