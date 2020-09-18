using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("setDescription")]
    public class ShippingMethodSetDescriptionAction : ShippingMethodUpdateAction
    {
        public string Description { get; set;}
    }
}
