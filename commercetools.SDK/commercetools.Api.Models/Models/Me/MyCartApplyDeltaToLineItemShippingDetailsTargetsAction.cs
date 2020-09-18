using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("applyDeltaToLineItemShippingDetailsTargets")]
    public class MyCartApplyDeltaToLineItemShippingDetailsTargetsAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemShippingTarget> TargetsDelta { get; set;}
    }
}
