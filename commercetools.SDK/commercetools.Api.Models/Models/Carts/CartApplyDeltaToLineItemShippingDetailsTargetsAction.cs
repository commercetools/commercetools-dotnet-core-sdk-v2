using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("applyDeltaToLineItemShippingDetailsTargets")]
    public class CartApplyDeltaToLineItemShippingDetailsTargetsAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemShippingTarget> TargetsDelta { get; set;}
    }
}
