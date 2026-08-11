using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerUpdate))]
    public partial interface IMcpServerUpdate
    {
        long Version { get; set; }

        IList<IMcpServerUpdateAction> Actions { get; set; }

        IEnumerable<IMcpServerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
