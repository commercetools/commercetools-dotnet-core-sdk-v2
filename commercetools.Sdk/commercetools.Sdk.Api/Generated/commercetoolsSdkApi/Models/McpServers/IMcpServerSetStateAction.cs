using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetStateAction))]
    public partial interface IMcpServerSetStateAction : IMcpServerUpdateAction
    {
        IMcpServerState State { get; set; }

    }
}
