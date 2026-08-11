using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetAuthenticationModeAction))]
    public partial interface IMcpServerSetAuthenticationModeAction : IMcpServerUpdateAction
    {
        IMcpServerAuthenticationMode AuthenticationMode { get; set; }

    }
}
