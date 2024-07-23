using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApproverHierarchyDraft))]
    public partial interface IApproverHierarchyDraft
    {
        IList<IApproverConjunctionDraft> Tiers { get; set; }
        IEnumerable<IApproverConjunctionDraft> TiersEnumerable { set => Tiers = value.ToList(); }


    }
}
