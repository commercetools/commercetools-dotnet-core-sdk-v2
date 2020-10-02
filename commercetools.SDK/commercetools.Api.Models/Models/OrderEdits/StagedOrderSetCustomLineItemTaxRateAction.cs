using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomLineItemTaxRate")]
    public partial class StagedOrderSetCustomLineItemTaxRateAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetCustomLineItemTaxRateAction()
        { 
           this.Action = "setCustomLineItemTaxRate";
        }
    }
}
