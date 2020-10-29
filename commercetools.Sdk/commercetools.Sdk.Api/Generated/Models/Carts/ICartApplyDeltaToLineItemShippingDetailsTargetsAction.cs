using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    public interface ICartApplyDeltaToLineItemShippingDetailsTargetsAction : ICartUpdateAction
    {
        string LineItemId { get; set;}
        
        List<IItemShippingTarget> TargetsDelta { get; set;}
    }
}
