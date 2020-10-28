using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetShippingMethodAction : ICartSetShippingMethodAction
    {
        public string Action { get; set;}
        
        public IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetShippingMethodAction()
        { 
           this.Action = "setShippingMethod";
        }
    }
}
