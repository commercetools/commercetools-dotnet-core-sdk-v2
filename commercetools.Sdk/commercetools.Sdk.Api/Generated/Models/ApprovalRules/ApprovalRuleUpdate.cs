using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleUpdate : IApprovalRuleUpdate
    {
        public long Version { get; set; }

        public IList<IApprovalRuleUpdateAction> Actions { get; set; }
        public IEnumerable<IApprovalRuleUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
