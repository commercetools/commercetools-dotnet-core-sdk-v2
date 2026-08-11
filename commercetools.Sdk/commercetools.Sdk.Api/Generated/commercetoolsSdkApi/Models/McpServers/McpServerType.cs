using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerType : IMcpServerType
    {
        public string Type { get; set; }

        public string MajorVersion { get; set; }

        public IList<IMcpServerTypeTool> Tools { get; set; }

        public IEnumerable<IMcpServerTypeTool> ToolsEnumerable { set => Tools = value.ToList(); }
    }
}
