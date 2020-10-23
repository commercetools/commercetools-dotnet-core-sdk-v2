using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetLineItemShippingDetailsAction))]
    public interface IMyCartSetLineItemShippingDetailsAction : IMyCartUpdateAction
    {
        string LineItemId { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
