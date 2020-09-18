using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("applyDeltaToCustomLineItemShippingDetailsTargets")]
    public class CartApplyDeltaToCustomLineItemShippingDetailsTargetsAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemShippingTarget> TargetsDelta { get; set;}
    }
}
