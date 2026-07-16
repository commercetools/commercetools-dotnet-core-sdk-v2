using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerJsonOutputFiltering))]
    public partial interface IMcpServerJsonOutputFiltering
    {
        IMcpServerJsonOutputFilteringMatcher Redact { get; set; }

        IMcpServerJsonOutputFilteringMatcher Drop { get; set; }

        IList<string> FieldPathsToKeep { get; set; }

        IEnumerable<string> FieldPathsToKeepEnumerable { set => FieldPathsToKeep = value.ToList(); }

        string RedactedWith { get; set; }

    }
}
