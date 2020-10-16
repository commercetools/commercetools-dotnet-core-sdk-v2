using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingMethod")]
    public partial class CartSetShippingMethodAction : CartUpdateAction
    {
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetShippingMethodAction()
        { 
           this.Action = "setShippingMethod";
        }
    }
}
