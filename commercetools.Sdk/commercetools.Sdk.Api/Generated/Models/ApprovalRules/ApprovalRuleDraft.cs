using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleDraft : IApprovalRuleDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IApprovalRuleStatus Status { get; set; }

        public string Predicate { get; set; }

        public IApproverHierarchyDraft Approvers { get; set; }

        public IList<IRuleRequesterDraft> Requesters { get; set; }
        public IEnumerable<IRuleRequesterDraft> RequestersEnumerable { set => Requesters = value.ToList(); }

    }
}
