

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetJsonOutputFilteringAction : IMcpServerSetJsonOutputFilteringAction
    {
        public string Action { get; set; }

        public IMcpServerJsonOutputFiltering JsonOutputFiltering { get; set; }
        public McpServerSetJsonOutputFilteringAction()
        {
            this.Action = "setJsonOutputFiltering";
        }
    }
}
