using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApprovalRuleSetCustomTypeAction : IApprovalRuleSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ApprovalRuleSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
