using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverConjunctionDraft : IApproverConjunctionDraft
    {
        public IList<IApproverDisjunctionDraft> And { get; set; }
        public IEnumerable<IApproverDisjunctionDraft> AndEnumerable { set => And = value.ToList(); }

    }
}
