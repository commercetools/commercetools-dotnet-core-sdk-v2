using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("applyDeltaToLineItemShippingDetailsTargets")]
    public partial class MyCartApplyDeltaToLineItemShippingDetailsTargetsAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemShippingTarget> TargetsDelta { get; set;}
        public MyCartApplyDeltaToLineItemShippingDetailsTargetsAction()
        { 
           this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
