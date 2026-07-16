

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerRemoveToolCustomizationAction : IMcpServerRemoveToolCustomizationAction
    {
        public string Action { get; set; }

        public IRemoveToolCustomizationTarget ToolCustomization { get; set; }
        public McpServerRemoveToolCustomizationAction()
        {
            this.Action = "removeToolCustomization";
        }
    }
}
