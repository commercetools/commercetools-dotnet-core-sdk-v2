using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("setKey")]
    public class ShippingMethodSetKeyAction : ShippingMethodUpdateAction
    {
        public string Key { get; set;}
    }
}
