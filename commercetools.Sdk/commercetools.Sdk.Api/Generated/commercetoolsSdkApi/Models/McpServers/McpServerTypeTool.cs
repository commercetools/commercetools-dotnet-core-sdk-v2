using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerTypeTool : IMcpServerTypeTool
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string OperationType { get; set; }

        public IList<string> Groups { get; set; }

        public IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }
    }
}
