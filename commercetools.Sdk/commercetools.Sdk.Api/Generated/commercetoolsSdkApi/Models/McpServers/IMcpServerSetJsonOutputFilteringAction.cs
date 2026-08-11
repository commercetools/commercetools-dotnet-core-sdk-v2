using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetJsonOutputFilteringAction))]
    public partial interface IMcpServerSetJsonOutputFilteringAction : IMcpServerUpdateAction
    {
        IMcpServerJsonOutputFiltering JsonOutputFiltering { get; set; }

    }
}
