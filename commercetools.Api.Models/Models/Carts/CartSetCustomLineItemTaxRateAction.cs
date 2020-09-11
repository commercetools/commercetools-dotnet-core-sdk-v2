using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartSetCustomLineItemTaxRateAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
