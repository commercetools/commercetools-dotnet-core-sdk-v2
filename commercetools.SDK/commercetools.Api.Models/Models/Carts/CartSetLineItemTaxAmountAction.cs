using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemTaxAmount")]
    public class CartSetLineItemTaxAmountAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
    }
}
