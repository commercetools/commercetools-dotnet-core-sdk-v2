using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverConjunction : IApproverConjunction
    {
        public IList<IApproverDisjunction> And { get; set; }
        public IEnumerable<IApproverDisjunction> AndEnumerable { set => And = value.ToList(); }

    }
}
