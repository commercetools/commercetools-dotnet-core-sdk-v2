using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.McpServers
{

    public partial class McpServerJsonOutputFilteringMatcher : IMcpServerJsonOutputFilteringMatcher
    {
        public IList<string> FieldPaths { get; set; }

        public IEnumerable<string> FieldPathsEnumerable { set => FieldPaths = value.ToList(); }

        public IList<string> FieldNames { get; set; }

        public IEnumerable<string> FieldNamesEnumerable { set => FieldNames = value.ToList(); }

        public IList<string> FieldNameContains { get; set; }

        public IEnumerable<string> FieldNameContainsEnumerable { set => FieldNameContains = value.ToList(); }
    }
}
