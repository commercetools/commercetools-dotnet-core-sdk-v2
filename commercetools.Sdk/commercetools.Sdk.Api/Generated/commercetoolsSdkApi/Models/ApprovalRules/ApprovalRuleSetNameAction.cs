namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetNameAction : IApprovalRuleSetNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ApprovalRuleSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
