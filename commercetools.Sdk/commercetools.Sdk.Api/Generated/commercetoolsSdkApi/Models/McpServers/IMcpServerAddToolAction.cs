using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerAddToolAction))]
    public partial interface IMcpServerAddToolAction : IMcpServerUpdateAction
    {
        IMcpServerTool Tool { get; set; }

    }
}
