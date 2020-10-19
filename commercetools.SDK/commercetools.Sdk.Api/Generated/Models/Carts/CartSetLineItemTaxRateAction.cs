using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemTaxRate")]
    public partial class CartSetLineItemTaxRateAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetLineItemTaxRateAction()
        { 
           this.Action = "setLineItemTaxRate";
        }
    }
}
