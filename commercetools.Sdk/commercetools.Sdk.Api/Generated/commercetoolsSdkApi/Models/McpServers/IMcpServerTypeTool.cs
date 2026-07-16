using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerTypeTool))]
    public partial interface IMcpServerTypeTool
    {
        string Name { get; set; }

        string Description { get; set; }

        string OperationType { get; set; }

        IList<string> Groups { get; set; }

        IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }

    }
}
