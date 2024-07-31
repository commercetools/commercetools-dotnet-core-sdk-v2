using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowPagedQueryResponse))]
    public partial interface IApprovalFlowPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IApprovalFlow> Results { get; set; }

        IEnumerable<IApprovalFlow> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
