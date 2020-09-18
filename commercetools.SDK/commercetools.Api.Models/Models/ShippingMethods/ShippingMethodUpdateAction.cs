using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [Discriminator(nameof(Action))]
    public abstract class ShippingMethodUpdateAction 
    {
        public string Action { get; set;}
    }
}
