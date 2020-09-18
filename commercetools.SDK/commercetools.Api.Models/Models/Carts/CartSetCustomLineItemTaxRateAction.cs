using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomLineItemTaxRate")]
    public class CartSetCustomLineItemTaxRateAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
