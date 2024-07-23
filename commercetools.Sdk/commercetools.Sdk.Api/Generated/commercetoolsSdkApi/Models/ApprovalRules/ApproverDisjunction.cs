using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverDisjunction : IApproverDisjunction
    {
        public IList<IRuleApprover> Or { get; set; }
        public IEnumerable<IRuleApprover> OrEnumerable { set => Or = value.ToList(); }

    }
}
