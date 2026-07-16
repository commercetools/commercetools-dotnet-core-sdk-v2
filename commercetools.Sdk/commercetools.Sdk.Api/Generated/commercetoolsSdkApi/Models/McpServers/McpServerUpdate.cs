using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerUpdate : IMcpServerUpdate
    {
        public long Version { get; set; }

        public IList<IMcpServerUpdateAction> Actions { get; set; }

        public IEnumerable<IMcpServerUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
