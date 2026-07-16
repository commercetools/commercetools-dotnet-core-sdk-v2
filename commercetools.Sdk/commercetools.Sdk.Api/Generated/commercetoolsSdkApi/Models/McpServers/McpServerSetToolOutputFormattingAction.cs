

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetToolOutputFormattingAction : IMcpServerSetToolOutputFormattingAction
    {
        public string Action { get; set; }

        public IMcpServerToolOutputFormatting ToolOutputFormatting { get; set; }
        public McpServerSetToolOutputFormattingAction()
        {
            this.Action = "setToolOutputFormatting";
        }
    }
}
