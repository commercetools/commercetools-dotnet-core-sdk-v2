using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerJsonOutputFiltering : IMcpServerJsonOutputFiltering
    {
        public IMcpServerJsonOutputFilteringMatcher Redact { get; set; }

        public IMcpServerJsonOutputFilteringMatcher Drop { get; set; }

        public IList<string> FieldPathsToKeep { get; set; }

        public IEnumerable<string> FieldPathsToKeepEnumerable { set => FieldPathsToKeep = value.ToList(); }

        public string RedactedWith { get; set; }
    }
}
