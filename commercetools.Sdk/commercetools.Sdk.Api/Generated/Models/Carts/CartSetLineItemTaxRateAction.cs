using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemTaxRateAction : ICartSetLineItemTaxRateAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetLineItemTaxRateAction()
        { 
           this.Action = "setLineItemTaxRate";
        }
    }
}
