using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerType))]
    public partial interface IMcpServerType
    {
        string Type { get; set; }

        string MajorVersion { get; set; }

        IList<IMcpServerTypeTool> Tools { get; set; }

        IEnumerable<IMcpServerTypeTool> ToolsEnumerable { set => Tools = value.ToList(); }

    }
}
