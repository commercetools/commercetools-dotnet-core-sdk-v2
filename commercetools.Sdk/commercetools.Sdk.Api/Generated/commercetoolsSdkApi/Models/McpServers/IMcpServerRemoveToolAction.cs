using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolAction))]
    public partial interface IMcpServerRemoveToolAction : IMcpServerUpdateAction
    {
        IMcpServerTool Tool { get; set; }

    }
}
