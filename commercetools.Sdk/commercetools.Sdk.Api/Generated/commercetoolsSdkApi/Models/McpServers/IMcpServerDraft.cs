using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerDraft))]
    public partial interface IMcpServerDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IMcpServerAuthenticationMode AuthenticationMode { get; set; }

        IMcpServerState State { get; set; }

        IMcpServerConfigDraft McpServer { get; set; }

    }
}
