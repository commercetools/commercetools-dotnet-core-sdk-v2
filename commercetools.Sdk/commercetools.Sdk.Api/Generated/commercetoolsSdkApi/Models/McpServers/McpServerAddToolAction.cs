

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerAddToolAction : IMcpServerAddToolAction
    {
        public string Action { get; set; }

        public IMcpServerTool Tool { get; set; }
        public McpServerAddToolAction()
        {
            this.Action = "addTool";
        }
    }
}
