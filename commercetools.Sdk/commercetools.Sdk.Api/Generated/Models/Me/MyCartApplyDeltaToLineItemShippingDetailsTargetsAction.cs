using commercetools.Api.Models.Carts;
using System.Collections.Generic;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartApplyDeltaToLineItemShippingDetailsTargetsAction : IMyCartApplyDeltaToLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public List<IItemShippingTarget> TargetsDelta { get; set; }
        public MyCartApplyDeltaToLineItemShippingDetailsTargetsAction()
        {
            this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
