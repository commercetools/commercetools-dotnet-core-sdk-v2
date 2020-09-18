using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingRateInput")]
    public class CartSetShippingRateInputAction : CartUpdateAction
    {
        public ShippingRateInputDraft ShippingRateInput { get; set;}
    }
}
