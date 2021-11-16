using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartApplyDeltaToLineItemShippingDetailsTargetsAction : IMyCartApplyDeltaToLineItemShippingDetailsTargetsAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public List<IItemShippingTarget> TargetsDelta { get; set;}
        public MyCartApplyDeltaToLineItemShippingDetailsTargetsAction()
        { 
           this.Action = "applyDeltaToLineItemShippingDetailsTargets";
        }
    }
}
