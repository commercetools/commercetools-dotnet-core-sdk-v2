using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerJsonOutputFilteringMatcher))]
    public partial interface IMcpServerJsonOutputFilteringMatcher
    {
        IList<string> FieldPaths { get; set; }

        IEnumerable<string> FieldPathsEnumerable { set => FieldPaths = value.ToList(); }

        IList<string> FieldNames { get; set; }

        IEnumerable<string> FieldNamesEnumerable { set => FieldNames = value.ToList(); }

        IList<string> FieldNameContains { get; set; }

        IEnumerable<string> FieldNameContainsEnumerable { set => FieldNameContains = value.ToList(); }

    }
}
