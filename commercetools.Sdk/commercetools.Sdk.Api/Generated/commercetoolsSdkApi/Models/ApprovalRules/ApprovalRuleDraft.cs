using System.Collections.Generic;
using System.Linq;

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
