using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetShippingMethodTaxRateAction : ICartSetShippingMethodTaxRateAction
    {
        public string Action { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetShippingMethodTaxRateAction()
        { 
           this.Action = "setShippingMethodTaxRate";
        }
    }
}
