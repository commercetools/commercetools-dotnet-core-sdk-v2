using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowSetCustomTypeAction : IApprovalFlowSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ApprovalFlowSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
