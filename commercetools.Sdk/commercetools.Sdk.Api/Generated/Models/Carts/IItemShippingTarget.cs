using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ItemShippingTarget))]
    public partial interface IItemShippingTarget 
    {
        string AddressKey { get; set;}
        
        double Quantity { get; set;}
    }
}
