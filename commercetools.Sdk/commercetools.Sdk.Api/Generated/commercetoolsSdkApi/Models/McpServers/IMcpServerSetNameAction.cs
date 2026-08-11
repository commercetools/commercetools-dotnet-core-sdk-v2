using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetNameAction))]
    public partial interface IMcpServerSetNameAction : IMcpServerUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
