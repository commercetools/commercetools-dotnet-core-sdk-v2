using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerPagedQueryResponse : IMcpServerPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IMcpServer> Results { get; set; }

        public IEnumerable<IMcpServer> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
