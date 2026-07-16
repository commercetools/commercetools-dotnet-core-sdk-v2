

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerAddToolCustomizationAction : IMcpServerAddToolCustomizationAction
    {
        public string Action { get; set; }

        public IToolCustomization ToolCustomization { get; set; }
        public McpServerAddToolCustomizationAction()
        {
            this.Action = "addToolCustomization";
        }
    }
}
