using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverHierarchy : IApproverHierarchy
    {
        public IList<IApproverConjunction> Tiers { get; set; }

        public IEnumerable<IApproverConjunction> TiersEnumerable { set => Tiers = value.ToList(); }
    }
}
