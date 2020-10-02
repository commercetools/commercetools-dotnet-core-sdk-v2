using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingMethodTaxRate")]
    public partial class CartSetShippingMethodTaxRateAction : CartUpdateAction
    {
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetShippingMethodTaxRateAction()
        { 
           this.Action = "setShippingMethodTaxRate";
        }
    }
}
