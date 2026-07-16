using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetDescriptionAction))]
    public partial interface IMcpServerSetDescriptionAction : IMcpServerUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
