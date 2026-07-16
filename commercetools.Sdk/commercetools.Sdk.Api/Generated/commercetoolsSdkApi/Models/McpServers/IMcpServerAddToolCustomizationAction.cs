using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerAddToolCustomizationAction))]
    public partial interface IMcpServerAddToolCustomizationAction : IMcpServerUpdateAction
    {
        IToolCustomization ToolCustomization { get; set; }

    }
}
