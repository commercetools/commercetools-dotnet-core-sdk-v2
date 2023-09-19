namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetDescriptionAction : IApprovalRuleSetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ApprovalRuleSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
