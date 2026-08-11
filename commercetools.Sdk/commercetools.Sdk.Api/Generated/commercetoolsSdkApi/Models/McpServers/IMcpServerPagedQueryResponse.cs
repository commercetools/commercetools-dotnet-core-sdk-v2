using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.McpServers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.McpServers.McpServerPagedQueryResponse))]
    public partial interface IMcpServerPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IMcpServer> Results { get; set; }

        IEnumerable<IMcpServer> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
