using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemTaxRate")]
    public partial class StagedOrderSetLineItemTaxRateAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetLineItemTaxRateAction()
        { 
           this.Action = "setLineItemTaxRate";
        }
    }
}
