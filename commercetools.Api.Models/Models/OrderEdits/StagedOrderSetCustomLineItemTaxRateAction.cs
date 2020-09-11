using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetCustomLineItemTaxRateAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
