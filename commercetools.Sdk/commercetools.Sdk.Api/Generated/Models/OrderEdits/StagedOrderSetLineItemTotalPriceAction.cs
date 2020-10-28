using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLineItemTotalPriceAction : IStagedOrderSetLineItemTotalPriceAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        public StagedOrderSetLineItemTotalPriceAction()
        { 
           this.Action = "setLineItemTotalPrice";
        }
    }
}
