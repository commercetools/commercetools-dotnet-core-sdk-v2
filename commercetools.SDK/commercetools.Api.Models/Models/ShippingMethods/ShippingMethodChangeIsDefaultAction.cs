using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("changeIsDefault")]
    public class ShippingMethodChangeIsDefaultAction : ShippingMethodUpdateAction
    {
        public bool IsDefault { get; set;}
    }
}
