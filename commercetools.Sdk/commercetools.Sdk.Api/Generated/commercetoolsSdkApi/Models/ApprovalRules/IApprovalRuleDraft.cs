using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRuleDraft))]
    public partial interface IApprovalRuleDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IApprovalRuleStatus Status { get; set; }

        string Predicate { get; set; }

        IApproverHierarchyDraft Approvers { get; set; }

        IList<IRuleRequesterDraft> Requesters { get; set; }
        IEnumerable<IRuleRequesterDraft> RequestersEnumerable { set => Requesters = value.ToList(); }


    }
}
