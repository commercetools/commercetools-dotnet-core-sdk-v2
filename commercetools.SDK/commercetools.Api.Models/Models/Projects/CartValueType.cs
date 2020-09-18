using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DiscriminatorValue("CartValue")]
    public class CartValueType : ShippingRateInputType
    {
    }
}
