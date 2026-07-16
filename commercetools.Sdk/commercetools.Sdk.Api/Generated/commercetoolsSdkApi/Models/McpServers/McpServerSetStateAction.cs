

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetStateAction : IMcpServerSetStateAction
    {
        public string Action { get; set; }

        public IMcpServerState State { get; set; }
        public McpServerSetStateAction()
        {
            this.Action = "setState";
        }
    }
}
