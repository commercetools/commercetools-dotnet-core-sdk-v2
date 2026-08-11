using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerRemoveToolCustomizationAction))]
    public partial interface IMcpServerRemoveToolCustomizationAction : IMcpServerUpdateAction
    {
        IRemoveToolCustomizationTarget ToolCustomization { get; set; }

    }
}
