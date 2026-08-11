using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.RemoveToolCustomizationTarget))]
    public partial interface IRemoveToolCustomizationTarget
    {
        IMcpServerTool Tool { get; set; }

    }
}
