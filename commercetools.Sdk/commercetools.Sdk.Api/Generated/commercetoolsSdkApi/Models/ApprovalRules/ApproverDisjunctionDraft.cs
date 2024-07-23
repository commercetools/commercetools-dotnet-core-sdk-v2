using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverDisjunctionDraft : IApproverDisjunctionDraft
    {
        public IList<IRuleApproverDraft> Or { get; set; }
        public IEnumerable<IRuleApproverDraft> OrEnumerable { set => Or = value.ToList(); }

    }
}
