using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartApplyDeltaToLineItemShippingDetailsTargetsAction : ICartApplyDeltaToLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public List<IItemShippingTarget> TargetsDelta { get; set; }
        public CartApplyDeltaToLineItemShippingDetailsTargetsAction()
        {
            this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
