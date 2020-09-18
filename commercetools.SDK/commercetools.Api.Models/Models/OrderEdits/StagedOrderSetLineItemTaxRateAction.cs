using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemTaxRate")]
    public class StagedOrderSetLineItemTaxRateAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
