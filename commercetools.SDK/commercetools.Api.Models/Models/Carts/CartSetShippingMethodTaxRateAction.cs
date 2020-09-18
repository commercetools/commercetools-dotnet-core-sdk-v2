using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingMethodTaxRate")]
    public class CartSetShippingMethodTaxRateAction : CartUpdateAction
    {
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
