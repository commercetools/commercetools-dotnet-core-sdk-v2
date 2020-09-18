using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("shipping-method")]
    public class ShippingMethodReference : Reference
    {
        public ShippingMethod Obj { get; set;}
    }
}
