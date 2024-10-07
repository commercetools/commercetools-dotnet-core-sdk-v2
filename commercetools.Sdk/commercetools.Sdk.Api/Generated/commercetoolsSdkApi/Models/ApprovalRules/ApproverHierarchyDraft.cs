using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverHierarchyDraft : IApproverHierarchyDraft
    {
        public IList<IApproverConjunctionDraft> Tiers { get; set; }

        public IEnumerable<IApproverConjunctionDraft> TiersEnumerable { set => Tiers = value.ToList(); }
    }
}
