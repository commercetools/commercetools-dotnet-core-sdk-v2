namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetKeyAction : IApprovalRuleSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ApprovalRuleSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
