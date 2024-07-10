using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
