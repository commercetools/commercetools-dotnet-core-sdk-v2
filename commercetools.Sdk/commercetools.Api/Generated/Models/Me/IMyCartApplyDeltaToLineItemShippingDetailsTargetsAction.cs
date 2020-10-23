using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyCartApplyDeltaToLineItemShippingDetailsTargetsAction : IMyCartUpdateAction
    {
        string LineItemId { get; set;}
        
        List<IItemShippingTarget> TargetsDelta { get; set;}
    }
}
