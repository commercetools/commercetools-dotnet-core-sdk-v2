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
    public  partial class MyCartSetShippingMethodAction : IMyCartSetShippingMethodAction
    {
        public string Action { get; set;}
        
        public IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public MyCartSetShippingMethodAction()
        { 
           this.Action = "setShippingMethod";
        }
    }
}
