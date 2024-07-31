using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetRequestersAction : IApprovalRuleSetRequestersAction
    {
        public string Action { get; set; }

        public IList<IRuleRequesterDraft> Requesters { get; set; }

        public IEnumerable<IRuleRequesterDraft> RequestersEnumerable { set => Requesters = value.ToList(); }
        public ApprovalRuleSetRequestersAction()
        {
            this.Action = "setRequesters";
        }
    }
}
