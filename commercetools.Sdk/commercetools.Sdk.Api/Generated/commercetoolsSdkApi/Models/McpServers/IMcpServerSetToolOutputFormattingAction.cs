using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetToolOutputFormattingAction))]
    public partial interface IMcpServerSetToolOutputFormattingAction : IMcpServerUpdateAction
    {
        IMcpServerToolOutputFormatting ToolOutputFormatting { get; set; }

    }
}
