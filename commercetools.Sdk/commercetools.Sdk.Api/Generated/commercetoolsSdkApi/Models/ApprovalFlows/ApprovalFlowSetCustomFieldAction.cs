using System;

namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowSetCustomFieldAction : IApprovalFlowSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ApprovalFlowSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
