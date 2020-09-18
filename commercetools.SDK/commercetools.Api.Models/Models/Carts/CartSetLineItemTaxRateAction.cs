using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemTaxRate")]
    public class CartSetLineItemTaxRateAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
