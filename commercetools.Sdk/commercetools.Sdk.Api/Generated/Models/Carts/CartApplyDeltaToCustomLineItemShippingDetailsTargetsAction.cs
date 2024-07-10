using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction : ICartApplyDeltaToCustomLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IList<IItemShippingTarget> TargetsDelta { get; set; }
        public IEnumerable<IItemShippingTarget> TargetsDeltaEnumerable { set => TargetsDelta = value.ToList(); }

        public CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction()
        {
            this.Action = "applyDeltaToCustomLineItemShippingDetailsTargets";
        }
    }
}
