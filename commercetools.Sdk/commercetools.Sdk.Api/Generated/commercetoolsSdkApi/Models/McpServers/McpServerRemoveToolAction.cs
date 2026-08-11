

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerRemoveToolAction : IMcpServerRemoveToolAction
    {
        public string Action { get; set; }

        public IMcpServerTool Tool { get; set; }
        public McpServerRemoveToolAction()
        {
            this.Action = "removeTool";
        }
    }
}
