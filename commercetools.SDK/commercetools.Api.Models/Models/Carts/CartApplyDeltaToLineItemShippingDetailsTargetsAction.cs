using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("applyDeltaToLineItemShippingDetailsTargets")]
    public partial class CartApplyDeltaToLineItemShippingDetailsTargetsAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemShippingTarget> TargetsDelta { get; set;}
        public CartApplyDeltaToLineItemShippingDetailsTargetsAction()
        { 
           this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
