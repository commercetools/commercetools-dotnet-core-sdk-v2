using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerSetToolsAction : IMcpServerSetToolsAction
    {
        public string Action { get; set; }

        public IList<IMcpServerTool> Tools { get; set; }

        public IEnumerable<IMcpServerTool> ToolsEnumerable { set => Tools = value.ToList(); }
        public McpServerSetToolsAction()
        {
            this.Action = "setTools";
        }
    }
}
