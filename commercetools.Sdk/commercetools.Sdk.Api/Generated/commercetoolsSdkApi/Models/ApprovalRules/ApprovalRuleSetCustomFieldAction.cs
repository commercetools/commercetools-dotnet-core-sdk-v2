using System;

namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetCustomFieldAction : IApprovalRuleSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ApprovalRuleSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
