using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRulePagedQueryResponse))]
    public partial interface IApprovalRulePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IApprovalRule> Results { get; set; }

        IEnumerable<IApprovalRule> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
