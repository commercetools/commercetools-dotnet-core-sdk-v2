using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setShippingMethod")]
    public partial class MyCartSetShippingMethodAction : MyCartUpdateAction
    {
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public MyCartSetShippingMethodAction()
        { 
           this.Action = "setShippingMethod";
        }
    }
}
