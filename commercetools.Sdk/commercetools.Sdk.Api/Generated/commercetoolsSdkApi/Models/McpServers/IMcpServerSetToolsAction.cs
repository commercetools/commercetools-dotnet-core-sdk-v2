using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerSetToolsAction))]
    public partial interface IMcpServerSetToolsAction : IMcpServerUpdateAction
    {
        IList<IMcpServerTool> Tools { get; set; }

        IEnumerable<IMcpServerTool> ToolsEnumerable { set => Tools = value.ToList(); }

    }
}
