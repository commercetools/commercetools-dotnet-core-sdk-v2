using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemTotalPrice")]
    public partial class StagedOrderSetLineItemTotalPriceAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        public StagedOrderSetLineItemTotalPriceAction()
        { 
           this.Action = "setLineItemTotalPrice";
        }
    }
}
