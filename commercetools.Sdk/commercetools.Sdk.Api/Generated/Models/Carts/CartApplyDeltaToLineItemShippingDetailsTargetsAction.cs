using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartApplyDeltaToLineItemShippingDetailsTargetsAction : ICartApplyDeltaToLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IList<IItemShippingTarget> TargetsDelta { get; set; }
        public IEnumerable<IItemShippingTarget> TargetsDeltaEnumerable { set => TargetsDelta = value.ToList(); }

        public CartApplyDeltaToLineItemShippingDetailsTargetsAction()
        {
            this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
