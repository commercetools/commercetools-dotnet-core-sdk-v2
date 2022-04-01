using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction : ICartApplyDeltaToCustomLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public List<IItemShippingTarget> TargetsDelta { get; set; }
        public CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction()
        {
            this.Action = "applyDeltaToCustomLineItemShippingDetailsTargets";
        }
    }
}
