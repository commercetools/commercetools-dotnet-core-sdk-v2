using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomLineItemTaxRate")]
    public partial class CartSetCustomLineItemTaxRateAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public CartSetCustomLineItemTaxRateAction()
        { 
           this.Action = "setCustomLineItemTaxRate";
        }
    }
}
